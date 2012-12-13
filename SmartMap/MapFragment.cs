using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Net;

namespace Smart.Map
{
    /// <summary>
    /// 地图碎片
    /// </summary>
    public class MapFragment
    {
        public MapFragment()
        {
            this.FragmentSize = new Size() { Width = 128, Height = 128 };
            this.Format = ImageFormat.Png;
        }

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 保存路径
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// 下载地址
        /// </summary>
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 图片大小
        /// </summary>
        public Size FragmentSize { get; set; }

        /// <summary>
        /// 图片容量KB
        /// </summary>
        public float Capacity { get; set; }

        /// <summary>
        /// 图片格式
        /// </summary>
        public ImageFormat Format { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public Image Image { get; set; }

        /// <summary>
        /// 下载图片
        /// </summary>
        public void Download()
        {
            //http下载图片
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.DownloadUrl);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();

            Bitmap map = new Bitmap(stream);
            
            Image = map;

            stream.Close();
            response.Close();
        }
    }
}
