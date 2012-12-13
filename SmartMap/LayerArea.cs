using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Smart.Map
{
    /// <summary>
    /// 图层区域
    /// </summary>
    public class LayerArea
    {
        /// <summary>
        /// 区域开始坐标
        /// </summary>
        public Vectory2D Start { get; set; }

        /// <summary>
        /// 区域结束坐标
        /// </summary>
        public Vectory2D End { get; set; }

        /// <summary>
        /// 区域大小px
        /// </summary>
        public Size AreaSize { get; set; }

        /// <summary>
        /// 区域图片容量kb
        /// </summary>
        public float Size { get; set; }

        /// <summary>
        /// 瓦片大小
        /// </summary>
        public Size FragmentSize { get; set; }

        /// <summary>
        /// 区域瓦片总数
        /// </summary>
        public int FragmentCount
        {
            get
            {
                return this.MapFragments.Count();
            }
        }

        /// <summary>
        /// Url模板
        /// </summary>
        public string UrlTemplate { get; set; }

        /// <summary>
        /// 区域瓦片集合
        /// </summary>
        public List<MapFragment> MapFragments { get; set; }

        /// <summary>
        /// 组合图片
        /// </summary>
        /// <param name="fileName">保存文件名称</param>
        /// <param name="format">图片格式</param>
        /// <param name="zeroPoint">地图0点坐标位置</param>
        public void Compose(string fileName, ImageFormat format, ZeroPoint zeroPoint)
        {
            float xCount = this.End.X - this.Start.X;
            float yCount = this.End.Y - this.Start.Y;

            //垂直方向碎片总数
            int VerticalSizeCount = (int)Math.Abs(yCount);
            //水平方向总数
            int HorizontalSizeCount = (int)Math.Abs(xCount);

            //构建瓦片拼接的最终地图
            Bitmap map = new Bitmap(
                //水平方向元素总数*单个碎片图像宽度
                HorizontalSizeCount * (int)this.FragmentSize.Width,
                //垂直方向元素总数*单个碎片图片高度
                VerticalSizeCount * (int)this.FragmentSize.Height);

            //GDI+画图
            Graphics tempGraphics = Graphics.FromImage(map);

            //逐行循环
            for (int i = 0; i < HorizontalSizeCount; i++)
            {
                //逐列循环
                for (int j = 0; j < VerticalSizeCount; j++)
                {
                    //碎片绘制位置
                    Vectory2D point = new Vectory2D();
                    point.X = i * this.FragmentSize.Width;
                    point.Y = j * this.FragmentSize.Height;

                    //得到线性内存表的偏移量公式:偏移量=每行列数*当前行+当前列
                    int offset = VerticalSizeCount * i + j;

                    //将碎片绘制到内存
                    //绘图0点坐标左上角；地图0点坐标左下角
                    switch (zeroPoint)
                    {
                        case ZeroPoint.LeftBottom:
                            tempGraphics.DrawImage(
                                MapFragments[offset].Image,
                                point.X,
                                AreaSize.Height - point.Y - this.FragmentSize.Height);
                            break;
                        case ZeroPoint.LeftTop:
                            tempGraphics.DrawImage(
                                MapFragments[offset].Image,
                                point.X,
                                point.Y);
                            break;
                    }
                }
            }

            //保存
            tempGraphics.Dispose();
            map.Save(fileName, format);
        }

        /// <summary>
        /// 下载图片
        /// </summary>
        public void Download()
        {
            //构建碎片
            BindFragments();

            foreach (MapFragment map in MapFragments)
            {
                //是否可以考虑线程下载?
                map.Download();
            }
        }

        /// <summary>
        /// 构建碎片
        /// </summary>
        private void BindFragments()
        {
            this.MapFragments = new List<MapFragment>();
            float xCount = this.End.X - this.Start.X;
            float yCount = this.End.Y - this.Start.Y;

            //垂直方向碎片总数
            int VerticalSizeCount = (int)Math.Abs(yCount);
            //水平方向总数
            int HorizontalSizeCount = (int)Math.Abs(xCount);

            //初始化瓦片拼接图像大小
            this.AreaSize = new Map.Size()
            {
                Width = HorizontalSizeCount * (int)this.FragmentSize.Width,
                Height = VerticalSizeCount * (int)this.FragmentSize.Height
            };

            //圆点坐标：左下角
            //行单位总数循环
            for (int i = 0; i < HorizontalSizeCount; i++)
            {
                //列单位总数循环
                for (int j = 0; j < VerticalSizeCount; j++)
                {
                    #region 构建碎片请求Url地址
                    MapFragment fragment = new MapFragment();
                    fragment.FileName = Guid.NewGuid().ToString();
                    fragment.FragmentSize = this.FragmentSize;

                    float x = 0;
                    float y = 0;

                    //水平方向循环
                    if (xCount < 0)
                    {
                        //水平向左步进
                        x = this.Start.X - (i + 1);
                    }
                    else
                    {
                        //水平向右步进
                        x = this.Start.X + (i + 1);
                    }

                    //垂直方向循环
                    if (yCount < 0)
                    {
                        //垂直向下步进
                        y = this.Start.Y - (j + 1);
                    }
                    else
                    {
                        //垂直向上步进
                        y = this.Start.Y + (j + 1);
                    }

                    //替换Url模板标签x,y
                    string tempUrlTemplate = this.UrlTemplate;
                    tempUrlTemplate = tempUrlTemplate.Replace("{POINTX}", x.ToString());
                    tempUrlTemplate = tempUrlTemplate.Replace("{POINTY}", y.ToString());
                    fragment.DownloadUrl = tempUrlTemplate;

                    this.MapFragments.Add(fragment);
                    #endregion
                }
            }
        }
    }
}
