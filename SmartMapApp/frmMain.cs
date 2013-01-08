using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Smart.Map.App
{
    public partial class frmMain : Form
    {
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
