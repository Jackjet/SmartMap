using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Imaging;

namespace SmartMapTest
{
    [TestClass]
    public class LayerAreaTest
    {
        Smart.Map.LayerArea layerArea = new Smart.Map.LayerArea();
        
        [TestMethod]
        public void Compose()
        {
            #region 搜狗地图
            layerArea.FragmentSize = new Smart.Map.Size() { Width = 256, Height = 256 };

            //搜狗矢量地图788,256     左下角
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 788, Y = 256 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 790, Y = 258 };
            //layerArea.UrlTemplate = "http://p0.go2map.com/seamless1/0/174/717/3/1/{POINTX}_{POINTY}.png";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\搜狗矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);

            //搜狗卫星地图1639,513    左下角
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 1639, Y = 513 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 1643, Y = 515 };
            //layerArea.UrlTemplate = "http://hbpic0.go2map.com/seamless/0/180/716/8/2/{POINTX}_{POINTY}.JPG";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\搜狗卫星地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);

            //搜狗三维地图40,62   左上角
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 40, Y = 62 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 47, Y = 64 };
            //layerArea.UrlTemplate = "http://hbpic2.go2map.com/seamless1/beijing/mappic/png0/{POINTX},{POINTY}.jpg";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\搜狗三维地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);
            #endregion

            #region 百度地图
            //百度矢量地图(郑州市200米)
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 12335, Y = 4024 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 12376, Y = 3998 };
            //layerArea.UrlTemplate = "http://q8.baidu.com/it/u=x={POINTX};y={POINTY};z=16;v=014;type=web&fm=44";
            //layerArea.Download();
            //layerArea.Compose("d:\\郑州市200米_百度矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);

            //百度矢量地图(中国200米),碎片总数:32792886
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 7990, Y = 6889 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 14692, Y = 1996 };
            //layerArea.UrlTemplate = "http://q8.baidu.com/it/u=x={POINTX};y={POINTY};z=16;v=014;type=web&fm=44";
            //layerArea.Download();
            //layerArea.Compose("d:\\中国200米_百度矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);


            //百度卫星地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 1573, Y = 502 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 1575, Y = 504 };
            //layerArea.UrlTemplate = "http://q4.baidu.com/it/u=x={POINTX};y={POINTY};z=13;v=009;type=sate&fm=46";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\百度卫星地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);

            #endregion

            #region 谷歌地图
            //谷歌矢量地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 26734, Y = 13005 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 26737, Y = 13007 };
            //layerArea.UrlTemplate = "http://mt3.google.cn/vt/lyrs=m@200000000&hl=zh-CN&gl=CN&src=app&x={POINTX}&s=&y={POINTY}&z=15&s=Galil";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\谷歌矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);


            //谷歌卫星地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 26734, Y = 13005 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 26737, Y = 13007 };
            //layerArea.UrlTemplate = "http://mt3.google.cn/vt/lyrs=s@122&hl=zh-CN&gl=CN&src=app&x={POINTX}&s=&y={POINTY}&z=15&s=Gali";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\谷歌卫星地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);

            #endregion

            #region E都市地图
            //E都市矢量地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 50615, Y = 16422 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 50618, Y = 16424 };
            //layerArea.UrlTemplate = "http://p0.go2map.com/seamless1/0/174/711/253/82/{POINTX}_{POINTY}.GIF";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\E都市矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);


            //E都市卫星地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 50611, Y = 16424 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 50614, Y = 16426 };
            //layerArea.UrlTemplate = "http://hbpic2.go2map.com/seamless/0/180/711/253/82/{POINTX}_{POINTY}.JPG";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\E都市卫星地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);

            //E都市三维地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 43, Y = 18 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 47, Y = 20 };
            //layerArea.UrlTemplate = "http://npic2.edushi.com/cn/zhengzhou/zh-chs/mappic/png1/{POINTX},{POINTY}.png";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\E都市三维地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);

            #endregion

            #region 天地图
            //天地图矢量地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 106934, Y = 20110 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 106937, Y = 20112 };
            //layerArea.UrlTemplate = "http://tile5.tianditu.com/DataServer?T=tdt_vec_dong_11_18_dyd&X={POINTX}&Y={POINTY}&L=17";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\天地图矢量地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);


            //天地图卫星地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 106936, Y = 20111 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 106939, Y = 20113 };
            //layerArea.UrlTemplate = "http://tile0.tianditu.com/DataServer?T=tdt_vip_img_120627_dyd&X={POINTX}&Y={POINTY}&L=17";
            //layerArea.Download();
            //layerArea.Compose("c:\\chache\\天地图卫星地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);

            //天地图地形地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 6650, Y = 1247 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 6653, Y = 1249 };
            //layerArea.UrlTemplate = "http://tile7.tianditu.com/DataServer?T=DemYunXun_E13&X={POINTX}&Y={POINTY}&L=13";
            //layerArea.Download();
            //layerArea.Compose("c:\\cache\\天地图地形地图.Png", ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);

            #endregion

            #region 济源市虎岭产业集聚区
            //天地图卫星地图
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 106936, Y = 20111 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 106939, Y = 20113 };
            //layerArea.UrlTemplate = "http://tile0.tianditu.com/DataServer?T=tdt_vip_img_120627_dyd&X={POINTX}&Y={POINTY}&L=17";
            //layerArea.Download();
            //layerArea.Compose(@"E:\三维统计地理信息系统\济源市虎岭镇三维产业集聚区\卫星地图\天地图卫星地图.Png", 
            //    ImageFormat.Png, 
            //    Smart.Map.ZeroPoint.LeftTop);

            //谷歌卫星地图
            //layerArea.FragmentSize = new Smart.Map.Size() { Width = 256, Height = 256 };
            //layerArea.Start = new Smart.Map.Vectory2D() { X = 425986, Y = 207502 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 426107, Y = 207641 };
            //layerArea.End = new Smart.Map.Vectory2D() { X = 425989, Y = 207509 };
            //layerArea.UrlTemplate = "http://mt0.google.cn/vt/lyrs=s@123&hl=zh-CN&gl=CN&src=app&x={POINTX}&y={POINTY}&z=19&s=Galil";
            //layerArea.Download();
            //layerArea.Compose(@"E:\三维统计地理信息系统\济源市虎岭镇三维产业集聚区\卫星地图\谷歌卫星地图.Png",
            //    ImageFormat.Png,
            //    Smart.Map.ZeroPoint.LeftTop);
            #endregion

            #region 许昌市尚集镇
            //天地图卫星地图
            /*
            http://tile1.tianditu.com/tdt/DataServer?T=t_img_271224&X=213945&Y=40680&L=18
            http://tile1.tianditu.com/tdt/DataServer?T=t_img_271224&X=213993&Y=40702&L=18
            */
            layerArea.Start = new Smart.Map.Vectory2D() { X = 213945, Y = 40680 };
            layerArea.End = new Smart.Map.Vectory2D() { X = 213993, Y = 40702 };
            layerArea.UrlTemplate = "http://tile1.tianditu.com/tdt/DataServer?T=t_img_271224&X={POINTX}&Y={POINTY}&L=18";
            layerArea.Download();
            layerArea.Compose(@"E:\三维统计地理信息系统\许昌市尚集镇三维产业集聚区\天地图卫星地图.Png",
                ImageFormat.Png,
                Smart.Map.ZeroPoint.LeftTop);
            #endregion
        }
    }
}
