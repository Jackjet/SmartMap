﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Smart.Map;
using System.Drawing.Imaging;

namespace Smart.Map.App
{
    public partial class frmMain : Form
    {
        Smart.Map.LayerArea layerArea = new Smart.Map.LayerArea();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.cbxZorePoint.SelectedIndex = 0;
        }

        private void btnCachePath_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            layerArea.UrlTemplate = cbxGisServerUrl.Text;
            layerArea.FragmentSize = new Smart.Map.Size() { Width = (float)numImageSize.Value, Height = (float)numImageSize.Value };

            layerArea.Start = new Smart.Map.Vectory2D()
            {
                X = (float)numStartPointX.Value,
                Y = (float)numStartPointY.Value
            };
            layerArea.End = new Smart.Map.Vectory2D()
            {
                X = (float)numEndPointX.Value,
                Y = (float)numEndPointY.Value
            };

            layerArea.Download(txtCachePath.Text);

            string filename = string.Format("{0}\\{1}.{2}",
                txtSavePath.Text,
                Guid.NewGuid().ToString(),
                ImageFormat.Png);
            if (cbxZorePoint.Text == "左上角")
            {
                layerArea.Compose(filename, ImageFormat.Png, Smart.Map.ZeroPoint.LeftTop);
            }
            else
            {
                layerArea.Compose(filename, ImageFormat.Png, Smart.Map.ZeroPoint.LeftBottom);
            }
        }

        private void btnClearCache_Click(object sender, EventArgs e)
        {
            //确定dialog
            if (Directory.Exists(txtCachePath.Text))
            {
                Directory.Delete(txtCachePath.Text, true);
                Directory.CreateDirectory(txtCachePath.Text);
            }

            rtxLog.AppendText("缓存清理完毕.\r\n");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
