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
            this.capturingTimer = new System.Windows.Forms.Timer(this.components);
            this.cam1InfoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loggerChkBox = new System.Windows.Forms.CheckBox();
            this.setupCam3Btn = new System.Windows.Forms.Button();
            this.setupCam2Btn = new System.Windows.Forms.Button();
            this.setupCam1Btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cam2InfoLabel = new System.Windows.Forms.Label();
            this.savePicBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.camList1.Location = new System.Drawing.Point(499, 323);
            this.camList1.Name = "camList1";
            this.camList1.Size = new System.Drawing.Size(142, 20);
            this.camList1.TabIndex = 6;
            // 
            // camList2
            // 
            this.camList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList2.DropDownWidth = 400;
            this.camList2.FormattingEnabled = true;
            this.camList2.Location = new System.Drawing.Point(499, 349);
            this.camList2.Name = "camList2";
            this.camList2.Size = new System.Drawing.Size(142, 20);
            this.camList2.TabIndex = 7;
            // 
            // camList3
            // 
            this.camList3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camList3.DropDownWidth = 400;
            this.camList3.FormattingEnabled = true;
            this.camList3.Location = new System.Drawing.Point(499, 375);
            this.camList3.Name = "camList3";
            this.camList3.Size = new System.Drawing.Size(142, 20);
            this.camList3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "カメラ1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "カメラ2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "カメラ3";
            // 
            // getCamListBtn
            // 
            this.getCamListBtn.Location = new System.Drawing.Point(377, 347);
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
            this.captureBtn.Location = new System.Drawing.Point(377, 404);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(75, 23);
            this.captureBtn.TabIndex = 14;
            this.captureBtn.Text = "キャプチャ";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // capturingTimer
            // 
            this.capturingTimer.Interval = 1000;
            this.capturingTimer.Tick += new System.EventHandler(this.capturingTimer_Tick);
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
            this.loggerChkBox.Location = new System.Drawing.Point(377, 471);
            this.loggerChkBox.Name = "loggerChkBox";
            this.loggerChkBox.Size = new System.Drawing.Size(82, 16);
            this.loggerChkBox.TabIndex = 20;
            this.loggerChkBox.Text = "DataLogger";
            this.loggerChkBox.UseVisualStyleBackColor = true;
            this.loggerChkBox.CheckedChanged += new System.EventHandler(this.loggerChkBox_CheckedChanged);
            // 
            // setupCam3Btn
            // 
            this.setupCam3Btn.Image = global::CameraApp.Properties.Resources.gear_16xLG;
            this.setupCam3Btn.Location = new System.Drawing.Point(647, 373);
            this.setupCam3Btn.Name = "setupCam3Btn";
            this.setupCam3Btn.Size = new System.Drawing.Size(25, 25);
            this.setupCam3Btn.TabIndex = 17;
            this.setupCam3Btn.UseVisualStyleBackColor = true;
            // 
            // setupCam2Btn
            // 
            this.setupCam2Btn.Image = global::CameraApp.Properties.Resources.gear_16xLG;
            this.setupCam2Btn.Location = new System.Drawing.Point(647, 347);
            this.setupCam2Btn.Name = "setupCam2Btn";
            this.setupCam2Btn.Size = new System.Drawing.Size(25, 25);
            this.setupCam2Btn.TabIndex = 16;
            this.setupCam2Btn.UseVisualStyleBackColor = true;
            // 
            // setupCam1Btn
            // 
            this.setupCam1Btn.Image = global::CameraApp.Properties.Resources.gear_16xLG;
            this.setupCam1Btn.Location = new System.Drawing.Point(647, 320);
            this.setupCam1Btn.Name = "setupCam1Btn";
            this.setupCam1Btn.Size = new System.Drawing.Size(25, 25);
            this.setupCam1Btn.TabIndex = 15;
            this.setupCam1Btn.UseVisualStyleBackColor = true;
            this.setupCam1Btn.Click += new System.EventHandler(this.setupCam1Btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 307);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 240);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(352, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 240);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.savePicBtn.Location = new System.Drawing.Point(534, 404);
            this.savePicBtn.Name = "savePicBtn";
            this.savePicBtn.Size = new System.Drawing.Size(75, 23);
            this.savePicBtn.TabIndex = 22;
            this.savePicBtn.Text = "画像の保存";
            this.savePicBtn.UseVisualStyleBackColor = true;
            this.savePicBtn.Click += new System.EventHandler(this.savePicBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 621);
            this.Controls.Add(this.savePicBtn);
            this.Controls.Add(this.cam2InfoLabel);
            this.Controls.Add(this.loggerChkBox);
            this.Controls.Add(this.cam1InfoLabel);
            this.Controls.Add(this.setupCam3Btn);
            this.Controls.Add(this.setupCam2Btn);
            this.Controls.Add(this.setupCam1Btn);
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
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "統合処理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
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
        private System.Windows.Forms.Button setupCam1Btn;
        private System.Windows.Forms.Button setupCam2Btn;
        private System.Windows.Forms.Button setupCam3Btn;
        private System.Windows.Forms.Timer capturingTimer;
        private System.Windows.Forms.Label cam1InfoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.CheckBox loggerChkBox;
        private System.Windows.Forms.Label cam2InfoLabel;
        private System.Windows.Forms.Button savePicBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}

