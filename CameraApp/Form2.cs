using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CaioCs;

namespace CameraApp
{
    public partial class Form2 : Form
    {
        Caio aio = new Caio();
        Boolean form2show = true;
        Boolean aioDeviceExist = false;
        List<string> devList = new List<string>();
        List<string> devNameList = new List<string>();

        float[] aioVoltData = new float[10000];

        short devId = 0;

        public Form2()
        {
            InitializeComponent();
        }

        //子フォームを閉じられないようにする
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;

                return createParams;
            }
        }

        //位置追従
        public void formLocation()
        {
            if (form2show && followFormChk.Checked)
            {
                Rectangle ownerLocation = this.Owner.Bounds;
                Point location = new Point();

                location.X = ownerLocation.X + ownerLocation.Width;
                location.Y = ownerLocation.Y;

                this.Location = location;
            }
        }

        //フォームロード時、およびメインフォーム移動時の位置決め(追従)
        private void Form2_Load(object sender, EventArgs e)
        {
            formLocation();
            this.Owner.Move += (sarg, earg) => formLocation();
            //this.Owner.SizeChanged += (sarg, earg) => formLocation();
            this.Width = 340;
        }

        //ステータスメッセージ表示
        private void statusMsg(int state,string msg)
        {
            if (msg == null)//nullならcaio絡みのメッセージとする
            {
                if (state == 0)
                {
                    statusLabel2.ForeColor = Color.Black;
                    statusLabel2.Text = "正常終了";
                }
                else
                {
                    statusLabel2.ForeColor = Color.Red;
                    string errorString;
                    aio.GetErrorString(state, out errorString);
                    statusLabel2.Text = state.ToString() + "-" + errorString;
                    return;
                }
            }
            else
            {
                if (state == 0)//nullでなかったらstateで色を決める。
                {
                    statusLabel2.ForeColor = Color.Black;
                    statusLabel2.Text = msg;
                }
                else
                {
                    statusLabel2.ForeColor = Color.Red;
                    statusLabel2.Text = msg;
                }
            }
        }

        //CAIOデバイスの取得、初期化
        private void caioGetDevice()
        {
            devList.Clear();
            devNameList.Clear();
            string devDriverId = null;
            string devName = null;
            short count = 0;
            int devState = 0;
            comboBox1.Items.Clear();
            while (devState == 0)
            {
                devState = aio.QueryDeviceName(count, out devDriverId, out devName);
                if (devState == 0)
                {
                    devList.Add(devDriverId);
                    devNameList.Add(devName);
                    count++;
                }
            }
            if (count > 0)
            {
                foreach (string device in devList)
                {
                    comboBox1.Items.Add(device);
                    comboBox1.SelectedIndex = 0;
                }
                statusMsg(0, ("デバイスが" + count.ToString() + "個見つかりました").ToString());
                maxChLabel.Text = "";
                aioDeviceExist = true;
                initAioDeviceBtn.Enabled = true;
            }
            else
            {
                aioDeviceExist = false;
                statusMsg(1, "デバイスが見つかりません");
            }
        }

        //デバイスの初期化
        private void caioInitDevice()
        {
            if (aioDeviceExist)
            {
                int aioInitState = aio.Init(comboBox1.SelectedItem.ToString(), out devId);
                if (aioInitState != 0)
                {
                    statusMsg(aioInitState, null);
                    return;
                }

                int aioResetState = 0;
                aioResetState = aio.ResetDevice(devId);
                if (aioResetState != 0)
                {
                    statusMsg(aioResetState, null);
                    return;
                }
                caioGetChannel();
                statusMsg(0, "デバイスの初期化に成功しました");
                loggingStartBtn.Enabled = true;
                testLoggingBtn.Enabled = true;
            }
            else
            {
                statusMsg(1, "デバイス取得を先に行ってください。");
            }
        }

        //チャンネル数取得
        private void caioGetChannel()
        {
            short ch = 0;
            int aioChannelState = aio.GetAiMaxChannels(devId, out ch);
            if (aioChannelState != 0)
            {
                statusMsg(aioChannelState, null);
                return;
            }
            else
            {
                xAxisListBox.Items.Clear();
                yAxisListBox.Items.Clear();
                for (int i = 0; i < ch; i++)
                {
                    xAxisListBox.Items.Add(i);
                    yAxisListBox.Items.Add(i);
                }
                xAxisListBox.SelectedIndex = 0;
                yAxisListBox.SelectedIndex = 1;
            }

            maxChLabel.Text = ch.ToString() + "ch";

        }

        //ロガーの設定
        private void setLogger()
        {
            //使用チャンネル数(1～2)
            int aioCh = aio.SetAiChannels(devId, 1);
            if (aioCh != 0)
            {
                statusMsg(aioCh, null);
                return;
            }

            //メモリ格納形式(FIFO固定)
            int aioMem = aio.SetAiMemoryType(devId,0);
            if (aioMem != 0)
            {
                statusMsg(aioMem, null);
                return;
            }

            //クロック(データボード内部のものを使用)
            int aioClk = aio.SetAiClockType(devId, 0);
            if (aioClk != 0)
            {
                statusMsg(aioClk, null);
                return;
            }

            //変換速度(間隔)
            int aioSpd = aio.SetAiSamplingClock(devId, 1000);
            if (aioSpd != 0)
            {
                statusMsg(aioSpd, null);
                return;
            }
            //開始条件(SW側)
            int aioStartTrg = aio.SetAiStartTrigger(devId, 0);
            if (aioStartTrg != 0)
            {
                statusMsg(aioStartTrg, null);
                return;
            }
            
            //停止条件(SW側)
            int aioStopTrg = aio.SetAiStopTrigger(devId, 0);
            if (aioStopTrg != 0)
            {
                statusMsg(aioStopTrg, null);
                return;
            }
        }

        private void resetAioMem()
        {
            int aioResMem = aio.ResetAiMemory(devId);
            if (aioResMem != 0)
            {
                statusMsg(aioResMem, null);
                return;
            }

        }

        private void drawGraph()
        {

        }

        private void getAioDeviceBtn_Click(object sender, EventArgs e)
        {
            caioGetDevice();
        }

        private void initAioDeviceBtn_Click(object sender, EventArgs e)
        {
            caioInitDevice();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2show = false;
        }

        private void followFormChk_CheckStateChanged(object sender, EventArgs e)
        {
            formLocation();
        }

        private void advSetChkBtn_CheckStateChanged(object sender, EventArgs e)
        {
            if (advSetChkBtn.Checked)
            {
                this.Width = 580;
            }
            else
            {
                this.Width = 340;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            devNameLabel.Text = devNameList[comboBox1.SelectedIndex];
            loggingStartBtn.Enabled = false;
            testLoggingBtn.Enabled = false;
        }

        private void loggingStartBtn_Click(object sender, EventArgs e)
        {
            if (loggingStartBtn.Text == "開始")
            {
                resetAioMem();
                int aioStartLogging = aio.StartAi(devId);
                if (aioStartLogging != 0)
                {
                    statusMsg(aioStartLogging, null);
                    return;
                }
                statusLabel2.Text = "変換を開始しました";
                loggingStartBtn.Text = "取得中...";
                //timer1.Start();
            }
            else
            {
                //timer1.Stop();
                loggingStartBtn.Text = "開始";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = 1000;
            aio.GetAiSamplingDataEx(devId, ref a,ref aioVoltData);
        }

        //とりあえず実装(FIFOで)
        private void testLoggingBtn_Click(object sender, EventArgs e)
        {
            resetAioMem();
            int aioStartLogging = aio.StartAi(devId);
            if (aioStartLogging != 0)
            {
                statusMsg(aioStartLogging, null);
                return;
            }
            System.Threading.Thread.Sleep(1000);
            int a = 1000;
            aio.GetAiSamplingDataEx(devId, ref a, ref aioVoltData);
            aio.StopAi(devId);
            listBox1.Items.Clear();
            for (int i = 0; i < a; i++)
            {
                listBox1.Items.Add(aioVoltData[i]);
            }
        }
    }
}