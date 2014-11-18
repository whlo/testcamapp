using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.CPlusPlus;

namespace CameraApp
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource1 = null;
        private bool DeviceExist = false;
        private bool CameraCapturing = false;

        private Form logForm = new Form2();

        private Mat captureImg = new Mat();

        public Form1()
        {
            InitializeComponent();
        }

        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                //コンボボックス内の全アイテムを消去
                for (int i = 0; i < 3; i++)
                {
                    ComboBox(i + 1).Items.Clear();
                }
                //カメラが存在しない場合にExceptionを飛ばす
                if (videoDevices.Count == 0)
                {
                    throw new ApplicationException();
                }
                DeviceExist = true;
                //カメラが存在するとき、コンボボックスに追加
                foreach (FilterInfo device in videoDevices)
                {
                    for (int i = 0; i < videoDevices.Count; i++)
                    {
                        ComboBox(i + 1).Items.Add(device.Name + " | (" + device.MonikerString + ")");
                    }
                }
                //初期選択項目を指定する
                for (int i = 0; i < videoDevices.Count; i++)
                {
                    ComboBox(i + 1).SelectedIndex = i;
                }
                statusLabel.ForeColor = Color.Black;
                statusLabel.Text = "デバイスが" + videoDevices.Count + "個見つかりました。";
            }
            //飛ばされたExceptionをキャッチする
            catch (ApplicationException)
            {
                DeviceExist = false;
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "デバイスが見つかりません。\nカメラが正常に接続されているか確認してください。";
            }
        }

        //インデクサっぽいもの。コンボボックスの名前を返す。
        private ComboBox ComboBox(int index)
        {
            return (ComboBox)(this.Controls["camList" + index.ToString()]);
        }

        //画像表示
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            using (Mat resizedImg = new Mat(Cv.Size(320, 240), MatType.CV_8U))
            using (captureImg = eventArgs.Frame.ToMat())
            {
                Cv2.Resize(captureImg, resizedImg, resizedImg.Size(), 1, 1, Interpolation.Linear);
                pictureBox1.Image = resizedImg.ToBitmap();
            }
        }

        //リソース開放
        private void CloseVideoSource()
        {
            if (!(videoSource1 == null))
            {
                if (videoSource1.IsRunning)
                {
                    videoSource1.SignalToStop();
                    videoSource1 = null;
                }
            }
        }

        //画像の保存
        private void saveImage(Mat Image, int camIndex)
        {
            captureBtn_Click(null, null);
            string date = DateTime.Now.ToString("HH/mm/ss,fff");
            Image.SaveImage(string.Format("{0} - {1}.bmp", camIndex, date));
        }

        private void getCamListBtn_Click(object sender, EventArgs e)
        {
            getCamList();
        }

        //キャプチャ実行
        private void captureBtn_Click(object sender, EventArgs e)
        {
            if (CameraCapturing == false)
            {
                if (DeviceExist)
                {
                    CameraCapturing = true;
                    //カメラ呼び出し...
                    camCapture(1);
                    statusLabel.Text = "キャプチャ中...";
                    captureBtn.Text = "Running...";
                    capturingTimer.Enabled = true;
                }
                else
                {
                    statusLabel.Text = "デバイスが存在しません。";
                }
            }
            else
            {
                if (videoSource1.IsRunning)
                {
                    capturingTimer.Enabled = false;
                    CameraCapturing = false;
                    CloseVideoSource();
                    statusLabel.Text = "停止しました。";
                    captureBtn.Text = "キャプチャ";
                }
            }
        }

        //カメラキャプチャ用
        public void camCapture(int camNum)
        {
            videoSource1 = new VideoCaptureDevice(videoDevices[ComboBox(camNum).SelectedIndex].MonikerString);
            videoSource1.NewFrame += new NewFrameEventHandler(video_NewFrame);
            CloseVideoSource();
            videoSource1.Start();
        }

        private void setupCam1Btn_Click(object sender, EventArgs e)
        {
            Form form2 = new VideoCaptureDeviceForm();
            form2.ShowDialog();
        }

        //フォームが閉じた時
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }

        //FPS表示
        private void capturingTimer_Tick(object sender, EventArgs e)
        {
            cam1InfoLabel.Text = videoSource1.FramesReceived.ToString() + "FPS";
        }

        //子フォームの表示
        private void loggerChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loggerChkBox.Checked)
            {
                logForm.Show(this);
            }
            else
            {
                logForm.Close();
            }
        }

        private void savePicBtn_Click(object sender, EventArgs e)
        {
            saveImage(captureImg, 1);
        }

        //form2から呼び出される
        public void logFormData(bool flag)
        {
            if (flag && CameraCapturing)
            {
                captureBtn_Click(null, null);
                System.Threading.Thread.Sleep(500);
                captureBtn_Click(null, null);
            }
            else
            {
                captureBtn_Click(null, null);
            }
        }
    }
}
