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

        short devId = 0;

        public Form2()
        {
            InitializeComponent();
        }
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
            this.Owner.SizeChanged += (sarg, earg) => formLocation();
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
                }
            }
            else
            {
                if (state == 0)//nullでなかったらstateで色を決める
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
            List<string> devList = new List<string>();
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
            }
            else
            {
                aioDeviceExist = false;
            }
        }

        //デバイスの初期化
        private void caioInitDevice()
        {
            if (aioDeviceExist)
            {
                int aioDeviceState = 0;
                aioDeviceState = aio.Init(comboBox1.SelectedItem.ToString(), out devId);
                if (aioDeviceState != 0)
                {
                    statusMsg(aioDeviceState, null);
                    return;
                }
                statusMsg(0, "デバイスの初期化に成功しました");
                caioGetChannel();
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
            int aioChannelState = 0;
            aioChannelState = aio.GetAiMaxChannels(devId, out ch);
            if (aioChannelState != 0)
            {
                statusMsg(aioChannelState, null);
            }
            else
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < ch; i++)
                {
                    comboBox2.Items.Add(i);
                }
                comboBox2.SelectedIndex = 0;
            }
            maxChLabel.Text = "最大" + ch.ToString() + "ch";
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

    }
}