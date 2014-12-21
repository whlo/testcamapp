namespace CameraApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allDataExp = new System.Windows.Forms.CheckBox();
            this.expCsvBtn = new System.Windows.Forms.Button();
            this.loggingStartBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.yAxisListBox = new System.Windows.Forms.ListBox();
            this.xAxisListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.initAioDeviceBtn = new System.Windows.Forms.Button();
            this.getAioDeviceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maxChLabel = new System.Windows.Forms.Label();
            this.followFormChk = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.advSetChkBtn = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.averagingTimes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.convTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yDataBox = new System.Windows.Forms.ListBox();
            this.convSpeed = new System.Windows.Forms.Label();
            this.devStLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.forceResetBtn = new System.Windows.Forms.Button();
            this.data2Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data1Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.xDataBox = new System.Windows.Forms.ListBox();
            this.devNameLabel = new System.Windows.Forms.Label();
            this.devMemoryTimer = new System.Windows.Forms.Timer(this.components);
            this.standaloneLogTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 247);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allDataExp);
            this.groupBox1.Controls.Add(this.expCsvBtn);
            this.groupBox1.Controls.Add(this.loggingStartBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yAxisListBox);
            this.groupBox1.Controls.Add(this.xAxisListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.initAioDeviceBtn);
            this.groupBox1.Controls.Add(this.getAioDeviceBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データボード処理";
            // 
            // allDataExp
            // 
            this.allDataExp.AutoSize = true;
            this.allDataExp.Location = new System.Drawing.Point(6, 146);
            this.allDataExp.Name = "allDataExp";
            this.allDataExp.Size = new System.Drawing.Size(116, 16);
            this.allDataExp.TabIndex = 15;
            this.allDataExp.Text = "全てのデータを出力";
            this.allDataExp.UseVisualStyleBackColor = true;
            // 
            // expCsvBtn
            // 
            this.expCsvBtn.Location = new System.Drawing.Point(6, 117);
            this.expCsvBtn.Name = "expCsvBtn";
            this.expCsvBtn.Size = new System.Drawing.Size(75, 23);
            this.expCsvBtn.TabIndex = 14;
            this.expCsvBtn.Text = "Export CSV";
            this.expCsvBtn.UseVisualStyleBackColor = true;
            this.expCsvBtn.Click += new System.EventHandler(this.expCsvBtn_Click);
            // 
            // loggingStartBtn
            // 
            this.loggingStartBtn.Enabled = false;
            this.loggingStartBtn.Location = new System.Drawing.Point(6, 76);
            this.loggingStartBtn.Name = "loggingStartBtn";
            this.loggingStartBtn.Size = new System.Drawing.Size(75, 23);
            this.loggingStartBtn.TabIndex = 11;
            this.loggingStartBtn.Text = "開始";
            this.loggingStartBtn.UseVisualStyleBackColor = true;
            this.loggingStartBtn.Click += new System.EventHandler(this.loggingStartBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "y軸";
            // 
            // yAxisListBox
            // 
            this.yAxisListBox.FormattingEnabled = true;
            this.yAxisListBox.ItemHeight = 12;
            this.yAxisListBox.Location = new System.Drawing.Point(199, 52);
            this.yAxisListBox.Name = "yAxisListBox";
            this.yAxisListBox.Size = new System.Drawing.Size(48, 88);
            this.yAxisListBox.TabIndex = 9;
            // 
            // xAxisListBox
            // 
            this.xAxisListBox.FormattingEnabled = true;
            this.xAxisListBox.ItemHeight = 12;
            this.xAxisListBox.Location = new System.Drawing.Point(116, 52);
            this.xAxisListBox.Name = "xAxisListBox";
            this.xAxisListBox.Size = new System.Drawing.Size(48, 88);
            this.xAxisListBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "x軸";
            // 
            // initAioDeviceBtn
            // 
            this.initAioDeviceBtn.Enabled = false;
            this.initAioDeviceBtn.Location = new System.Drawing.Point(6, 47);
            this.initAioDeviceBtn.Name = "initAioDeviceBtn";
            this.initAioDeviceBtn.Size = new System.Drawing.Size(75, 23);
            this.initAioDeviceBtn.TabIndex = 4;
            this.initAioDeviceBtn.Text = "初期化";
            this.initAioDeviceBtn.UseVisualStyleBackColor = true;
            this.initAioDeviceBtn.Click += new System.EventHandler(this.initAioDeviceBtn_Click);
            // 
            // getAioDeviceBtn
            // 
            this.getAioDeviceBtn.Location = new System.Drawing.Point(6, 18);
            this.getAioDeviceBtn.Name = "getAioDeviceBtn";
            this.getAioDeviceBtn.Size = new System.Drawing.Size(75, 23);
            this.getAioDeviceBtn.TabIndex = 2;
            this.getAioDeviceBtn.Text = "デバイス取得";
            this.getAioDeviceBtn.UseVisualStyleBackColor = true;
            this.getAioDeviceBtn.Click += new System.EventHandler(this.getAioDeviceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "データボード";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maxChLabel
            // 
            this.maxChLabel.AutoSize = true;
            this.maxChLabel.Location = new System.Drawing.Point(107, 48);
            this.maxChLabel.Name = "maxChLabel";
            this.maxChLabel.Size = new System.Drawing.Size(11, 12);
            this.maxChLabel.TabIndex = 7;
            this.maxChLabel.Text = "0";
            // 
            // followFormChk
            // 
            this.followFormChk.AutoSize = true;
            this.followFormChk.Checked = true;
            this.followFormChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.followFormChk.Location = new System.Drawing.Point(12, 26);
            this.followFormChk.Name = "followFormChk";
            this.followFormChk.Size = new System.Drawing.Size(107, 16);
            this.followFormChk.TabIndex = 2;
            this.followFormChk.Text = "メイン画面に追従";
            this.followFormChk.UseVisualStyleBackColor = true;
            this.followFormChk.CheckStateChanged += new System.EventHandler(this.followFormChk_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusLabel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 553);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoEllipsis = true;
            this.statusLabel2.Location = new System.Drawing.Point(6, 15);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(288, 35);
            this.statusLabel2.TabIndex = 0;
            this.statusLabel2.Text = "停止しています";
            // 
            // advSetChkBtn
            // 
            this.advSetChkBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.advSetChkBtn.Location = new System.Drawing.Point(241, 22);
            this.advSetChkBtn.Name = "advSetChkBtn";
            this.advSetChkBtn.Size = new System.Drawing.Size(75, 23);
            this.advSetChkBtn.TabIndex = 4;
            this.advSetChkBtn.Text = "詳細設定→";
            this.advSetChkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.advSetChkBtn.UseVisualStyleBackColor = true;
            this.advSetChkBtn.CheckStateChanged += new System.EventHandler(this.advSetChkBtn_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "デバイス名 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "最大チャンネル数 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "動作状態 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.averagingTimes);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.convTime);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.yDataBox);
            this.groupBox3.Controls.Add(this.convSpeed);
            this.groupBox3.Controls.Add(this.devStLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.forceResetBtn);
            this.groupBox3.Controls.Add(this.data2Label);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.data1Label);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.xDataBox);
            this.groupBox3.Controls.Add(this.devNameLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.maxChLabel);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(334, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 583);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "データボード詳細設定";
            // 
            // averagingTimes
            // 
            this.averagingTimes.AutoSize = true;
            this.averagingTimes.Location = new System.Drawing.Point(107, 204);
            this.averagingTimes.Name = "averagingTimes";
            this.averagingTimes.Size = new System.Drawing.Size(11, 12);
            this.averagingTimes.TabIndex = 26;
            this.averagingTimes.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "平均化回数 :";
            // 
            // convTime
            // 
            this.convTime.AutoSize = true;
            this.convTime.Location = new System.Drawing.Point(107, 178);
            this.convTime.Name = "convTime";
            this.convTime.Size = new System.Drawing.Size(11, 12);
            this.convTime.TabIndex = 24;
            this.convTime.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "変換回数 :";
            // 
            // yDataBox
            // 
            this.yDataBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yDataBox.FormattingEnabled = true;
            this.yDataBox.ItemHeight = 12;
            this.yDataBox.Location = new System.Drawing.Point(111, 328);
            this.yDataBox.Name = "yDataBox";
            this.yDataBox.Size = new System.Drawing.Size(93, 220);
            this.yDataBox.TabIndex = 22;
            // 
            // convSpeed
            // 
            this.convSpeed.AutoSize = true;
            this.convSpeed.Location = new System.Drawing.Point(107, 152);
            this.convSpeed.Name = "convSpeed";
            this.convSpeed.Size = new System.Drawing.Size(11, 12);
            this.convSpeed.TabIndex = 21;
            this.convSpeed.Text = "0";
            // 
            // devStLabel
            // 
            this.devStLabel.AutoSize = true;
            this.devStLabel.Location = new System.Drawing.Point(107, 74);
            this.devStLabel.Name = "devStLabel";
            this.devStLabel.Size = new System.Drawing.Size(28, 12);
            this.devStLabel.TabIndex = 20;
            this.devStLabel.Text = "Stop";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "変換速度 :";
            // 
            // forceResetBtn
            // 
            this.forceResetBtn.Location = new System.Drawing.Point(139, 554);
            this.forceResetBtn.Name = "forceResetBtn";
            this.forceResetBtn.Size = new System.Drawing.Size(75, 23);
            this.forceResetBtn.TabIndex = 17;
            this.forceResetBtn.Text = "ForceReset";
            this.forceResetBtn.UseVisualStyleBackColor = true;
            this.forceResetBtn.Click += new System.EventHandler(this.forceResetBtn_Click);
            // 
            // data2Label
            // 
            this.data2Label.AutoSize = true;
            this.data2Label.Location = new System.Drawing.Point(107, 126);
            this.data2Label.Name = "data2Label";
            this.data2Label.Size = new System.Drawing.Size(11, 12);
            this.data2Label.TabIndex = 16;
            this.data2Label.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "y値 :";
            // 
            // data1Label
            // 
            this.data1Label.AutoSize = true;
            this.data1Label.Location = new System.Drawing.Point(107, 100);
            this.data1Label.Name = "data1Label";
            this.data1Label.Size = new System.Drawing.Size(11, 12);
            this.data1Label.TabIndex = 14;
            this.data1Label.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "x値 :";
            // 
            // xDataBox
            // 
            this.xDataBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.xDataBox.FormattingEnabled = true;
            this.xDataBox.ItemHeight = 12;
            this.xDataBox.Location = new System.Drawing.Point(8, 328);
            this.xDataBox.Name = "xDataBox";
            this.xDataBox.Size = new System.Drawing.Size(93, 220);
            this.xDataBox.TabIndex = 12;
            // 
            // devNameLabel
            // 
            this.devNameLabel.AutoSize = true;
            this.devNameLabel.Location = new System.Drawing.Point(107, 22);
            this.devNameLabel.Name = "devNameLabel";
            this.devNameLabel.Size = new System.Drawing.Size(27, 12);
            this.devNameLabel.TabIndex = 11;
            this.devNameLabel.Text = "N/A";
            // 
            // devMemoryTimer
            // 
            this.devMemoryTimer.Tick += new System.EventHandler(this.devMemoryTimer_Tick);
            // 
            // standaloneLogTimer
            // 
            this.standaloneLogTimer.Interval = 1000;
            this.standaloneLogTimer.Tick += new System.EventHandler(this.standaloneLogTimer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.advSetChkBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.followFormChk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "DataLogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button getAioDeviceBtn;
        private System.Windows.Forms.CheckBox followFormChk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label statusLabel2;
        private System.Windows.Forms.Button initAioDeviceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxChLabel;
        private System.Windows.Forms.ListBox xAxisListBox;
        private System.Windows.Forms.ListBox yAxisListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox advSetChkBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label devNameLabel;
        private System.Windows.Forms.Button loggingStartBtn;
        private System.Windows.Forms.Timer devMemoryTimer;
        private System.Windows.Forms.ListBox xDataBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label data2Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button expCsvBtn;
        private System.Windows.Forms.Button forceResetBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label devStLabel;
        private System.Windows.Forms.Label convSpeed;
        private System.Windows.Forms.Label data1Label;
        private System.Windows.Forms.ListBox yDataBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label convTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox allDataExp;
        private System.Windows.Forms.Label averagingTimes;
        private System.Windows.Forms.Timer standaloneLogTimer;
    }
}