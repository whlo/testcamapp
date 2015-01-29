using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace CameraApp {
    public partial class Form1 : Form {
        private FilterInfoCollection videoDevices;
        private bool DeviceExist = false;
        private bool CameraCapturing = false;
        private VideoCaptureDevice videoSource1 = null;
        private VideoCaptureDevice videoSource2 = null;
        private VideoCaptureDevice videoSource3 = null;


        string filepath = Environment.CurrentDirectory;

        Form2 logForm = new Form2();

        public Form1() {
            InitializeComponent();
        }

        //インデクサっぽいもの。
        private ComboBox ComboBox(int index) {
            return (ComboBox)(this.Controls["camList" + index.ToString()]);
        }
        private CheckBox CheckBox(int index) {
            return (CheckBox)(this.Controls["cam" + index.ToString() + "SaveChk"]);
        }


        //ステータスメッセージ表示
        private void statusMsg(int state, string msg) {
            if (state == 0) {
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = msg;
            } else {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = msg;
            }
        }

        /* 
         * 画像表示関連ここから
         */
        private void getCamListBtn_Click(object sender, EventArgs e) {
            try {
                listBoxClear();
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //カメラが存在しない場合にExceptionを飛ばす
                if (videoDevices.Count == 0) {
                    throw new ApplicationException();
                }
                DeviceExist = true;
                //カメラが存在するとき、コンボボックスにデバイス名を追加
                foreach (FilterInfo device in videoDevices) {
                    for (int i = 1; i < 3 + 1; i++) {
                        ComboBox(i).Items.Add(device.Name + " | (" + device.MonikerString + ")");
                    }
                }
                //初期選択項目を指定する
                for (int i = 1; i <= videoDevices.Count; i++) {
                    if (i <= 3) {
                        ComboBox(i).SelectedIndex = i;
                    }
                }
                statusMsg(0, "デバイスが" + videoDevices.Count + "個見つかりました。");
            }
            //飛ばされたExceptionをキャッチする
            catch (ApplicationException) {
                DeviceExist = false;
                statusMsg(1, "デバイスが見つかりません。\nカメラが正常に接続されているか確認してください。");
            }
        }

        //カメラキャプチャ用
        public void camCapture() {
            if (camList1.SelectedIndex != 0) {
                videoSource1 = new VideoCaptureDevice(videoDevices[camList1.SelectedIndex - 1].MonikerString);
                videoSourcePlayer1.VideoSource = videoSource1;
                videoSourcePlayer1.Start();
            }
            if (camList2.SelectedIndex != 0) {
                videoSource2 = new VideoCaptureDevice(videoDevices[camList2.SelectedIndex - 1].MonikerString);
                videoSourcePlayer2.VideoSource = videoSource2;
                videoSourcePlayer2.Start();
            }
            if (camList3.SelectedIndex != 0) {
                videoSource3 = new VideoCaptureDevice(videoDevices[camList3.SelectedIndex - 1].MonikerString);
                videoSourcePlayer3.VideoSource = videoSource3;
                videoSourcePlayer3.Start();
            }
            CameraCapturing = true;
        }

        //キャプチャ実行
        private void captureBtn_Click(object sender, EventArgs e) {
            if (CameraCapturing == false) {
                if (DeviceExist) {
                    CameraCapturing = true;
                    //カメラ呼び出し...
                    camCapture();
                    statusMsg(0, "キャプチャ中...");
                    captureBtn.Text = "Running...";
                    saveImgTiming.Enabled = false;
                    CaptureTimer.Interval = (int)saveImgTiming.Value;
                    CaptureTimer.Enabled = true;
                    fpsTimer.Enabled = true;
                } else {
                    statusMsg(1, "デバイスが存在しません。");
                }
            } else {
                if (CameraCapturing) {
                    fpsTimer.Enabled = false;
                    CaptureTimer.Enabled = false;
                    saveImgTiming.Enabled = true;
                    CameraCapturing = false;
                    videoSourcePlayer1.SignalToStop();
                    videoSourcePlayer2.SignalToStop();
                    videoSourcePlayer3.SignalToStop();

                    videoSourcePlayer1.WaitForStop();
                    videoSourcePlayer2.WaitForStop();
                    videoSourcePlayer3.WaitForStop();

                    statusMsg(0, "停止しました。");
                    captureBtn.Text = "キャプチャ";
                }
            }
        }
        /*
         * 画像表示関連ここまで
        */


        //コンボボックス内の初期化
        private void listBoxClear() {
            for (int i = 1; i < 4; i++) {
                ComboBox(i).Items.Clear();
            }
            for (int i = 1; i < 4; i++) {
                ComboBox(i).Items.Add("無効");
                ComboBox(i).SelectedIndex = 0;
            }
        }

        //フォームが閉じた時
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            CloseVideoSource();
        }

        //リソース開放
        private void CloseVideoSource()
        {
            if (videoSource1 != null)
            {
                if (videoSource1.IsRunning)
                {
                    videoSource1.SignalToStop();
                    videoSource1 = null;
                }
            }
            if (videoSource2 != null) {
                if (videoSource2.IsRunning) {
                    videoSource2.SignalToStop();
                    videoSource2 = null;
                }
            }
            if (videoSource3 != null) {
                if (videoSource3.IsRunning) {
                    videoSource3.SignalToStop();
                    videoSource3 = null;
                }
            }
        }

        //FPS表示
        private void fpsTimer_Tick(object sender, EventArgs e) {
            if (CameraCapturing) {
                if (videoSourcePlayer1.IsRunning) cam1InfoLabel.Text = videoSource1.FramesReceived + "FPS";
                if (videoSourcePlayer2.IsRunning) cam2InfoLabel.Text = videoSource2.FramesReceived + "FPS";
                if (videoSourcePlayer3.IsRunning) cam3InfoLabel.Text = videoSource3.FramesReceived + "FPS";
            }
        }

        //子フォームの表示
        private void loggerChkBox_CheckedChanged(object sender, EventArgs e) {
            if (loggerChkBox.Checked) {
                logForm = new Form2();
                logForm.Owner = this;
                logForm.Show(this);
            } else {
                logForm.Close();
            }
        }

        //form2から呼び出される
        public void logFormData(bool flag) {
            if (flag) {
                if (DeviceExist) {
                    if (CameraCapturing) {
                        captureBtn_Click(null, null);
                        System.Threading.Thread.Sleep(2000);
                        captureBtn_Click(null, null);
                    } else {
                        captureBtn_Click(null, null);
                    }
                } else {
                    logForm.timerStart(true);
                }
            } else {
                if (DeviceExist && CameraCapturing) {
                    captureBtn_Click(null, null);
                } else {
                    logForm.timerStart(false);
                }
            }
        }


        /*
         * 画像の保存ここから
        */
        private void savePicBtn_Click(object sender, EventArgs e) {
            if (cam1SaveChk.Checked) saveFile(videoSourcePlayer1.GetCurrentVideoFrame(), 1);
            if (cam2SaveChk.Checked) saveFile(videoSourcePlayer2.GetCurrentVideoFrame(), 2);
            if (cam3SaveChk.Checked) saveFile(videoSourcePlayer3.GetCurrentVideoFrame(), 3);
        }

        private void saveFile(Bitmap bmpImg, int camIndex) {
            DateTime currentTime = DateTime.Now;
            //DateTime b = currentTime.AddSeconds(-1);    //デバッグ用
            string date = currentTime.ToString("HH-mm-ss,fff");
            logForm.getAverage(currentTime);
            string fileName = System.IO.Path.Combine(filepath, string.Format(@"test\{0} - cam{1}.bmp", date, camIndex));
            if (bmpImg != null) {
                bmpImg.Save(fileName,ImageFormat.Bmp);
                bmpImg.Dispose();
            }
        }

        private void CaptureTimer_Tick(object sender, EventArgs e) {
            if (cam1SaveChk.Checked && videoSourcePlayer1.IsRunning) saveFile(videoSourcePlayer1.GetCurrentVideoFrame(), 1);
            if (cam2SaveChk.Checked && videoSourcePlayer2.IsRunning) saveFile(videoSourcePlayer2.GetCurrentVideoFrame(), 2);
            if (cam3SaveChk.Checked && videoSourcePlayer3.IsRunning) saveFile(videoSourcePlayer3.GetCurrentVideoFrame(), 3);
        }
        /*
         * 画像の保存ここまで
        */


        private void saveImgChkCtrl(int index) {
            if (ComboBox(index).SelectedItem.ToString() == "無効") {
                CheckBox(index).Checked = false;
                CheckBox(index).Enabled = false;
            } else {
                CheckBox(index).Checked = true;
                CheckBox(index).Enabled = true;
            }
        }

        private void camList1_SelectedIndexChanged(object sender, EventArgs e) {
            saveImgChkCtrl(1);
        }

        private void camList2_SelectedIndexChanged(object sender, EventArgs e) {
            saveImgChkCtrl(2);
        }

        private void camList3_SelectedIndexChanged(object sender, EventArgs e) {
            saveImgChkCtrl(3);
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void saveImgTiming_ValueChanged(object sender, EventArgs e) {
            if (saveImgTiming.Value < 1000) {
                timingWarnLabel.ForeColor = Color.Red;
                timingWarnLabel.Text = ("1000ms以下では動作が不安定になります。");
            } else {
                timingWarnLabel.ForeColor = Color.Black;
                timingWarnLabel.Text = ("");
            }
        }

    }


}
