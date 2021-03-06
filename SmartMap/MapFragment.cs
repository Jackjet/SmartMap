﻿using System;
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
            this.FragmentSize = new Size() { Width = 256, Height = 256 };
            this.Format = ImageFormat.Png;

            this.SavePath = AppDomain.CurrentDomain.BaseDirectory + "\\images";
            this.FileName = string.Format("{0}.{1}", Guid.NewGuid().ToString(), this.Format.ToString());

            if (!Directory.Exists(this.SavePath))
            {
                Directory.CreateDirectory(this.SavePath);
            }
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
        /// 下载图片
        /// </summary>
        public void Download()
        {
            string filename = this.SavePath + "\\" + this.FileName;
            if (!File.Exists(filename))
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(this.DownloadUrl);
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK && response.ContentLength > 0)
                {
                    Stream stream = response.GetResponseStream();

                    Bitmap map = new Bitmap(stream);
                    map.Save(filename, this.Format);

                    map.Dispose();
                    stream.Close();
                    stream.Dispose();
                    response.Close();
                }
                else
                {
                    //创建一张空白图片
                    Bitmap map = new Bitmap((int)this.FragmentSize.Width, (int)this.FragmentSize.Height);
                    map.Save(filename, this.Format);
                    map.Dispose();
                    response.Close();
                }
            }
        }
    }
}
