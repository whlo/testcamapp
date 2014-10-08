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

        //CAIOデバイスの取得、初期化
        private void caioInit()
        {
            List<string> devList = new List<string>();
            string devId = null;
            string devName = null;
            short count = 0;
            int devExist = 0;
            do
            {
                devExist = aio.QueryDeviceName(count, out devId, out devName);
                devList.Add(devId);
                count++;
            }
            while (devExist != 0);
            foreach (string device in devList)
            {
                comboBox1.Items.Add(device);
                comboBox1.SelectedIndex = 0;
            }

        }

        private void getAioDeviceBtn_Click(object sender, EventArgs e)
        {
            caioInit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2show = false;
        }

        private void followFormChk_CheckStateChanged(object sender, EventArgs e)
        {
            formLocation();
        }

        private void aioInitBtn_Click(object sender, EventArgs e)
        {
            int aioDevicestate;
            aioDevicestate = aio.Init(comboBox1.SelectedItem.ToString(), out devId);
        }
    }
}