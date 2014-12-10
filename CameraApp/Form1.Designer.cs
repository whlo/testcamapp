namespace CameraApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.camList1 = new System.Windows.Forms.ComboBox();
            this.camList2 = new System.Windows.Forms.ComboBox();
            this.camList3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.getCamListBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.captureBtn = new System.Windows.Forms.Button();
            this.fpsTimer = new System.Windows.Forms.Timer(this.components);
            this.cam1InfoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerChkBox = new System.Windows.Forms.CheckBox();
            this.cam2InfoLabel = new System.Windows.Forms.Label();
            this.savePicBtn = new System.Windows.Forms.Button();
            this.cam1SaveChk = new System.Windows.Forms.CheckBox();
            this.cam2SaveChk = new System.Windows.Forms.CheckBox();
            this.cam3SaveChk = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.saveImgTiming = new System.Windows.Forms.NumericUpDown();
            this.CaptureTimer = new System.Windows.Forms.Timer(this.components);
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer2 = new AForge.Controls.VideoSourcePlayer();
            this.videoSourcePlayer3 = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveImgTiming)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "カメラ1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "カメラ2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "カメラ3";
            // 
            // camList1
            // 
            this.camList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList1.DropDownWidth = 400;
            this.camList1.FormattingEnabled = true;
            this.camList1.Location = new System.Drawing.Point(485, 339);
            this.camList1.Name = "camList1";
            this.camList1.Size = new System.Drawing.Size(142, 20);
            this.camList1.TabIndex = 6;
            this.camList1.SelectedIndexChanged += new System.EventHandler(this.camList1_SelectedIndexChanged);
            // 
            // camList2
            // 
            this.camList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList2.DropDownWidth = 400;
            this.camList2.FormattingEnabled = true;
            this.camList2.Location = new System.Drawing.Point(485, 365);
            this.camList2.Name = "camList2";
            this.camList2.Size = new System.Drawing.Size(142, 20);
            this.camList2.TabIndex = 7;
            this.camList2.SelectedIndexChanged += new System.EventHandler(this.camList2_SelectedIndexChanged);
            // 
            // camList3
            // 
            this.camList3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList3.DropDownWidth = 400;
            this.camList3.FormattingEnabled = true;
            this.camList3.Location = new System.Drawing.Point(485, 391);
            this.camList3.Name = "camList3";
            this.camList3.Size = new System.Drawing.Size(142, 20);
            this.camList3.TabIndex = 8;
            this.camList3.SelectedIndexChanged += new System.EventHandler(this.camList3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "カメラ1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "カメラ2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "カメラ3";
            // 
            // getCamListBtn
            // 
            this.getCamListBtn.Location = new System.Drawing.Point(363, 363);
            this.getCamListBtn.Name = "getCamListBtn";
            this.getCamListBtn.Size = new System.Drawing.Size(75, 23);
            this.getCamListBtn.TabIndex = 12;
            this.getCamListBtn.Text = "デバイス取得";
            this.getCamListBtn.UseVisualStyleBackColor = true;
            this.getCamListBtn.Click += new System.EventHandler(this.getCamListBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 553);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(6, 15);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(76, 12);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "停止しています";
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(363, 420);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(75, 23);
            this.captureBtn.TabIndex = 14;
            this.captureBtn.Text = "キャプチャ";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // fpsTimer
            // 
            this.fpsTimer.Interval = 1000;
            this.fpsTimer.Tick += new System.EventHandler(this.capturingTimer_Tick);
            // 
            // cam1InfoLabel
            // 
            this.cam1InfoLabel.AutoSize = true;
            this.cam1InfoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cam1InfoLabel.Location = new System.Drawing.Point(54, 34);
            this.cam1InfoLabel.Name = "cam1InfoLabel";
            this.cam1InfoLabel.Size = new System.Drawing.Size(28, 12);
            this.cam1InfoLabel.TabIndex = 18;
            this.cam1InfoLabel.Text = "Stop";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // loggerChkBox
            // 
            this.loggerChkBox.AutoSize = true;
            this.loggerChkBox.Location = new System.Drawing.Point(363, 487);
            this.loggerChkBox.Name = "loggerChkBox";
            this.loggerChkBox.Size = new System.Drawing.Size(82, 16);
            this.loggerChkBox.TabIndex = 20;
            this.loggerChkBox.Text = "DataLogger";
            this.loggerChkBox.UseVisualStyleBackColor = true;
            this.loggerChkBox.CheckedChanged += new System.EventHandler(this.loggerChkBox_CheckedChanged);
            // 
            // cam2InfoLabel
            // 
            this.cam2InfoLabel.AutoSize = true;
            this.cam2InfoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cam2InfoLabel.Location = new System.Drawing.Point(392, 34);
            this.cam2InfoLabel.Name = "cam2InfoLabel";
            this.cam2InfoLabel.Size = new System.Drawing.Size(28, 12);
            this.cam2InfoLabel.TabIndex = 21;
            this.cam2InfoLabel.Text = "Stop";
            // 
            // savePicBtn
            // 
            this.savePicBtn.Location = new System.Drawing.Point(560, 420);
            this.savePicBtn.Name = "savePicBtn";
            this.savePicBtn.Size = new System.Drawing.Size(67, 23);
            this.savePicBtn.TabIndex = 22;
            this.savePicBtn.Text = "1timeSave";
            this.savePicBtn.UseVisualStyleBackColor = true;
            this.savePicBtn.Click += new System.EventHandler(this.savePicBtn_Click);
            // 
            // cam1SaveChk
            // 
            this.cam1SaveChk.AutoSize = true;
            this.cam1SaveChk.Location = new System.Drawing.Point(638, 342);
            this.cam1SaveChk.Name = "cam1SaveChk";
            this.cam1SaveChk.Size = new System.Drawing.Size(15, 14);
            this.cam1SaveChk.TabIndex = 24;
            this.cam1SaveChk.UseVisualStyleBackColor = true;
            // 
            // cam2SaveChk
            // 
            this.cam2SaveChk.AutoSize = true;
            this.cam2SaveChk.Location = new System.Drawing.Point(638, 368);
            this.cam2SaveChk.Name = "cam2SaveChk";
            this.cam2SaveChk.Size = new System.Drawing.Size(15, 14);
            this.cam2SaveChk.TabIndex = 25;
            this.cam2SaveChk.UseVisualStyleBackColor = true;
            // 
            // cam3SaveChk
            // 
            this.cam3SaveChk.AutoSize = true;
            this.cam3SaveChk.Location = new System.Drawing.Point(638, 394);
            this.cam3SaveChk.Name = "cam3SaveChk";
            this.cam3SaveChk.Size = new System.Drawing.Size(15, 14);
            this.cam3SaveChk.TabIndex = 26;
            this.cam3SaveChk.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "保存";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "間隔";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(536, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 12);
            this.label9.TabIndex = 29;
            this.label9.Text = "ms";
            // 
            // saveImgTiming
            // 
            this.saveImgTiming.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.saveImgTiming.Location = new System.Drawing.Point(485, 423);
            this.saveImgTiming.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.saveImgTiming.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.saveImgTiming.Name = "saveImgTiming";
            this.saveImgTiming.Size = new System.Drawing.Size(52, 19);
            this.saveImgTiming.TabIndex = 30;
            this.saveImgTiming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saveImgTiming.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.saveImgTiming.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // CaptureTimer
            // 
            this.CaptureTimer.Tick += new System.EventHandler(this.CaptureTimer_Tick);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(14, 49);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(320, 240);
            this.videoSourcePlayer1.TabIndex = 31;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // videoSourcePlayer2
            // 
            this.videoSourcePlayer2.Location = new System.Drawing.Point(352, 49);
            this.videoSourcePlayer2.Name = "videoSourcePlayer2";
            this.videoSourcePlayer2.Size = new System.Drawing.Size(320, 240);
            this.videoSourcePlayer2.TabIndex = 32;
            this.videoSourcePlayer2.Text = "videoSourcePlayer2";
            this.videoSourcePlayer2.VideoSource = null;
            // 
            // videoSourcePlayer3
            // 
            this.videoSourcePlayer3.Location = new System.Drawing.Point(14, 307);
            this.videoSourcePlayer3.Name = "videoSourcePlayer3";
            this.videoSourcePlayer3.Size = new System.Drawing.Size(320, 240);
            this.videoSourcePlayer3.TabIndex = 33;
            this.videoSourcePlayer3.Text = "videoSourcePlayer3";
            this.videoSourcePlayer3.VideoSource = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 621);
            this.Controls.Add(this.videoSourcePlayer3);
            this.Controls.Add(this.videoSourcePlayer2);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.saveImgTiming);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cam3SaveChk);
            this.Controls.Add(this.cam2SaveChk);
            this.Controls.Add(this.cam1SaveChk);
            this.Controls.Add(this.savePicBtn);
            this.Controls.Add(this.cam2InfoLabel);
            this.Controls.Add(this.loggerChkBox);
            this.Controls.Add(this.cam1InfoLabel);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getCamListBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.camList3);
            this.Controls.Add(this.camList2);
            this.Controls.Add(this.camList1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "カメラ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveImgTiming)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox camList1;
        private System.Windows.Forms.ComboBox camList2;
        private System.Windows.Forms.ComboBox camList3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button getCamListBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Timer fpsTimer;
        private System.Windows.Forms.Label cam1InfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.CheckBox loggerChkBox;
        private System.Windows.Forms.Label cam2InfoLabel;
        private System.Windows.Forms.Button savePicBtn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox cam1SaveChk;
        private System.Windows.Forms.CheckBox cam2SaveChk;
        private System.Windows.Forms.CheckBox cam3SaveChk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer CaptureTimer;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer3;
        protected System.Windows.Forms.NumericUpDown saveImgTiming;
    }
}

