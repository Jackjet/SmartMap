namespace Smart.Map.App
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxZorePoint = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numImageSize = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numEndPointY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numEndPointX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numStartPointY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numStartPointX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGisServerUrl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCachePath = new System.Windows.Forms.Button();
            this.txtCachePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.picLog = new System.Windows.Forms.PictureBox();
            this.rtxLog = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPointX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxZorePoint);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numImageSize);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numEndPointY);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numEndPointX);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numStartPointY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numStartPointX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxGisServerUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "瓦片选项";
            // 
            // cbxZorePoint
            // 
            this.cbxZorePoint.FormattingEnabled = true;
            this.cbxZorePoint.Items.AddRange(new object[] {
            "左上角",
            "左下角"});
            this.cbxZorePoint.Location = new System.Drawing.Point(465, 74);
            this.cbxZorePoint.Name = "cbxZorePoint";
            this.cbxZorePoint.Size = new System.Drawing.Size(134, 20);
            this.cbxZorePoint.TabIndex = 7;
            this.cbxZorePoint.Text = "左上角";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "零点坐标：";
            // 
            // numImageSize
            // 
            this.numImageSize.Location = new System.Drawing.Point(466, 44);
            this.numImageSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numImageSize.Name = "numImageSize";
            this.numImageSize.Size = new System.Drawing.Size(133, 21);
            this.numImageSize.TabIndex = 6;
            this.numImageSize.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "瓦片尺寸：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y";
            // 
            // numEndPointY
            // 
            this.numEndPointY.Location = new System.Drawing.Point(247, 75);
            this.numEndPointY.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numEndPointY.Name = "numEndPointY";
            this.numEndPointY.Size = new System.Drawing.Size(124, 21);
            this.numEndPointY.TabIndex = 5;
            this.numEndPointY.Value = new decimal(new int[] {
            40030,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // numEndPointX
            // 
            this.numEndPointX.Location = new System.Drawing.Point(94, 75);
            this.numEndPointX.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numEndPointX.Name = "numEndPointX";
            this.numEndPointX.Size = new System.Drawing.Size(124, 21);
            this.numEndPointX.TabIndex = 4;
            this.numEndPointX.Value = new decimal(new int[] {
            213085,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Y";
            // 
            // numStartPointY
            // 
            this.numStartPointY.Location = new System.Drawing.Point(247, 44);
            this.numStartPointY.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numStartPointY.Name = "numStartPointY";
            this.numStartPointY.Size = new System.Drawing.Size(124, 21);
            this.numStartPointY.TabIndex = 3;
            this.numStartPointY.Value = new decimal(new int[] {
            39984,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // numStartPointX
            // 
            this.numStartPointX.Location = new System.Drawing.Point(94, 44);
            this.numStartPointX.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numStartPointX.Name = "numStartPointX";
            this.numStartPointX.Size = new System.Drawing.Size(124, 21);
            this.numStartPointX.TabIndex = 2;
            this.numStartPointX.Value = new decimal(new int[] {
            212998,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "结束坐标：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "起始坐标：";
            // 
            // cbxGisServerUrl
            // 
            this.cbxGisServerUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGisServerUrl.FormattingEnabled = true;
            this.cbxGisServerUrl.Items.AddRange(new object[] {
            "http://tile6.tianditu.com/tdt/DataServer?T=t_img_271224&X={POINTX}&Y={POINTY}&L=1" +
                "8",
            "http://q8.baidu.com/it/u=x={POINTX};y={POINTY};z=16;v=014;type=web&fm=44",
            "http://q4.baidu.com/it/u=x={POINTX};y={POINTY};z=13;v=009;type=sate&fm=46",
            "http://p0.go2map.com/seamless1/0/174/717/3/1/{POINTX}_{POINTY}.png",
            "http://hbpic0.go2map.com/seamless/0/180/716/8/2/{POINTX}_{POINTY}.jpg",
            "http://hbpic2.go2map.com/seamless1/beijing/mappic/png0/{POINTX},{POINTY}.jpg",
            "http://p0.go2map.com/seamless1/0/174/711/253/82/{POINTX}_{POINTY}.GIF",
            "http://hbpic2.go2map.com/seamless/0/180/711/253/82/{POINTX}_{POINTY}.JPG",
            "http://npic2.edushi.com/cn/zhengzhou/zh-chs/mappic/png1/{POINTX},{POINTY}.png",
            "http://tile5.tianditu.com/DataServer?T=tdt_vec_dong_11_18_dyd&X={POINTX}&Y={POINT" +
                "Y}&L=17",
            "http://tile0.tianditu.com/DataServer?T=tdt_vip_img_120627_dyd&X={POINTX}&Y={POINT" +
                "Y}&L=17",
            "http://tile7.tianditu.com/DataServer?T=DemYunXun_E13&X={POINTX}&Y={POINTY}&L=13"});
            this.cbxGisServerUrl.Location = new System.Drawing.Point(77, 14);
            this.cbxGisServerUrl.Name = "cbxGisServerUrl";
            this.cbxGisServerUrl.Size = new System.Drawing.Size(522, 20);
            this.cbxGisServerUrl.TabIndex = 1;
            this.cbxGisServerUrl.Text = "http://tile6.tianditu.com/tdt/DataServer?T=t_img_271224&X={POINTX}&Y={POINTY}&L=1" +
                "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "瓦片网址：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnSavePath);
            this.groupBox2.Controls.Add(this.txtSavePath);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnCachePath);
            this.groupBox2.Controls.Add(this.txtCachePath);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出选项";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(522, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "处理进度：";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePath.Location = new System.Drawing.Point(524, 42);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSavePath.TabIndex = 4;
            this.btnSavePath.Text = "浏览(&B)";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(77, 42);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(441, 21);
            this.txtSavePath.TabIndex = 3;
            this.txtSavePath.Text = "D:\\\\MapResult";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "保存位置：";
            // 
            // btnCachePath
            // 
            this.btnCachePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCachePath.Location = new System.Drawing.Point(524, 12);
            this.btnCachePath.Name = "btnCachePath";
            this.btnCachePath.Size = new System.Drawing.Size(75, 23);
            this.btnCachePath.TabIndex = 2;
            this.btnCachePath.Text = "浏览(&B)";
            this.btnCachePath.UseVisualStyleBackColor = true;
            this.btnCachePath.Click += new System.EventHandler(this.btnCachePath_Click);
            // 
            // txtCachePath
            // 
            this.txtCachePath.Location = new System.Drawing.Point(77, 14);
            this.txtCachePath.Name = "txtCachePath";
            this.txtCachePath.Size = new System.Drawing.Size(441, 21);
            this.txtCachePath.TabIndex = 1;
            this.txtCachePath.Text = "D:\\\\MapCache";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "缓存位置：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.picLog);
            this.groupBox3.Controls.Add(this.rtxLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(605, 176);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "运行日志";
            // 
            // picLog
            // 
            this.picLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLog.Location = new System.Drawing.Point(449, 20);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(150, 150);
            this.picLog.TabIndex = 1;
            this.picLog.TabStop = false;
            // 
            // rtxLog
            // 
            this.rtxLog.Location = new System.Drawing.Point(8, 20);
            this.rtxLog.Name = "rtxLog";
            this.rtxLog.Size = new System.Drawing.Size(435, 150);
            this.rtxLog.TabIndex = 1;
            this.rtxLog.Text = "";
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(299, 420);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "运行(&R)";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClearCache
            // 
            this.btnClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCache.Location = new System.Drawing.Point(380, 420);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(75, 23);
            this.btnClearCache.TabIndex = 4;
            this.btnClearCache.Text = "清缓(&C)";
            this.btnClearCache.UseVisualStyleBackColor = true;
            this.btnClearCache.Click += new System.EventHandler(this.btnClearCache_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(542, 420);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "退出(&Q)";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(461, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 455);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClearCache);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地图瓦片下载工具V1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numImageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartPointX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.RichTextBox rtxLog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGisServerUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStartPointX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStartPointY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numEndPointY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numEndPointX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numImageSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxZorePoint;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCachePath;
        private System.Windows.Forms.TextBox txtCachePath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox picLog;
    }
}