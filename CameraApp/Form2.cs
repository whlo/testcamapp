using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CaioCs;

namespace CameraApp {
    public partial class Form2 : Form {
        Caio aio = new Caio();
        DataProcessing dataProc = new DataProcessing();
        Boolean form2show = true;
        Boolean aioDeviceInit = false;

        //デバイスリスト
        List<string> devList = new List<string>();
        List<string> devNameList = new List<string>();

        //取得電圧データ格納用
        List<DataPkt> xyVoltListPkt = new List<DataPkt>();
        DataList xyVoltList = new DataList();

        //平均化済みデータ格納用
        ConvPkt convPkt = new ConvPkt();

        //listBox表示用キュー
        Queue<string> xQueue = new Queue<string>();
        Queue<string> yQueue = new Queue<string>();

        int convertCount = 0;

        DateTime startTime;

        //デバイスID
        short devId = 0;

        public Form2() {
            InitializeComponent();
        }

        //子フォームを閉じられないようにする
        protected override System.Windows.Forms.CreateParams CreateParams {
            get {
                const int CS_NOCLOSE = 0x200;

                System.Windows.Forms.CreateParams createParams = base.CreateParams;
                createParams.ClassStyle |= CS_NOCLOSE;

                return createParams;
            }
        }

        //位置追従
        private void formLocation() {
            if (form2show && followFormChk.Checked) {
                Rectangle ownerLocation = this.Owner.Bounds;
                Point location = new Point();

                location.X = ownerLocation.X + ownerLocation.Width;
                location.Y = ownerLocation.Y;

                this.Location = location;
            }
        }

        //フォームロード時、およびメインフォーム移動時の位置決め(追従)
        private void Form2_Load(object sender, EventArgs e) {
            formLocation();
            this.Owner.Move += (sarg, earg) => formLocation();
            //this.Owner.SizeChanged += (sarg, earg) => formLocation();
            this.Width = 340;
        }

        //ステータスメッセージ表示
        private void statusMsg(int state, string msg) {
            if (msg == null)    //nullならcaio絡みのメッセージとする
            {
                if (state == 0) {
                    statusLabel2.ForeColor = Color.Black;
                    statusLabel2.Text = "正常終了";
                } else {
                    statusLabel2.ForeColor = Color.Red;
                    string errorString;
                    aio.GetErrorString(state, out errorString);
                    statusLabel2.Text = state.ToString() + "-" + errorString;
                    return;
                }
            } else {
                if (state == 0) //nullでなかったらstateで色を決める。
                {
                    statusLabel2.ForeColor = Color.Black;
                    statusLabel2.Text = msg;
                } else {
                    statusLabel2.ForeColor = Color.Red;
                    statusLabel2.Text = msg;
                }
            }
        }

        //CAIOデバイスの取得、初期化
        private void caioGetDevice() {
            devList.Clear();
            devNameList.Clear();
            xyVoltListPkt.Clear();
            xyVoltList.clear();
            convPkt.clear();
            string devDriverId = null;
            string devName = null;
            short count = 0;
            int devState = 0;
            comboBox1.Items.Clear();
            while (devState == 0) {
                devState = aio.QueryDeviceName(count, out devDriverId, out devName);
                if (devState == 0) {
                    devList.Add(devDriverId);
                    devNameList.Add(devName);
                    count++;
                }
            }
            if (count > 0) {
                foreach (string device in devList) {
                    comboBox1.Items.Add(device);
                    comboBox1.SelectedIndex = 0;
                }
                statusMsg(0, ("デバイスが" + count.ToString() + "個見つかりました").ToString());
                maxChLabel.Text = "";
                initAioDeviceBtn.Enabled = true;
            } else {
                statusMsg(1, "デバイスが見つかりません");
            }
        }

        //デバイスの初期化
        private void caioInitDevice() {
            if (aioDeviceInit == true) {
                aio.Exit(devId);
            }
            int aioInitState = aio.Init(comboBox1.SelectedItem.ToString(), out devId);
            if (devId == -1) {
                statusMsg(1, "デバイスが接続されていません");
                return;
            } else {
                if (aioInitState != 0) {
                    statusMsg(aioInitState, null);
                    return;
                } else {
                    int aioResetState = 0;
                    aioResetState = aio.ResetDevice(devId);
                    if (aioResetState != 0) {
                        statusMsg(aioResetState, null);
                        return;
                    }
                    caioGetChannel();
                    statusMsg(0, "デバイスの初期化に成功しました");
                    aioDeviceInit = true;
                }
            }
        }

        //チャンネル数取得
        private void caioGetChannel() {
            short ch = 0;
            int aioChannelState = aio.GetAiMaxChannels(devId, out ch);
            if (aioChannelState != 0) {
                statusMsg(aioChannelState, null);
                return;
            } else {
                xAxisListBox.Items.Clear();
                yAxisListBox.Items.Clear();
                for (int i = 0; i < ch; ++i) {
                    xAxisListBox.Items.Add(i);
                    yAxisListBox.Items.Add(i);
                }
                xAxisListBox.SelectedIndex = 0;
                yAxisListBox.SelectedIndex = 1;
            }
            maxChLabel.Text = ch.ToString() + "ch";
        }

        //ロガーの設定
        private void setLogger() {
            //入力方式
            int aioInputMethod = aio.SetAiInputMethod(devId, 0);    //シングルエンド
            if (aioInputMethod != 0) {
                statusMsg(aioInputMethod, null);
                return;
            }

            //チャネル変換順序
            //1664LAXではチャネルはAI00,AI01...の順で固定なのでエラー無視
            aio.SetAiChannelSequence(devId, 0, (short)xAxisListBox.SelectedIndex);
            aio.SetAiChannelSequence(devId, 1, (short)yAxisListBox.SelectedIndex);

            //使用チャネル数
            int aioCh = aio.SetAiChannels(devId, 2);    //2ch
            if (aioCh != 0) {
                statusMsg(aioCh, null);
                return;
            }

            //計測レンジ指定
            int aioRange = aio.SetAiRangeAll(devId, (short)CaioConst.PM5); //±5V
            if (aioRange != 0) {
                //1664LAXでは±10V固定
                statusMsg(aioRange, null);
                aioRange = aio.SetAiRangeAll(devId, (short)CaioConst.PM10); //±10V
                if (aioRange != 0) {
                    statusMsg(aioCh, null);
                    return;
                }
                statusMsg(1, "レンジが変更できないデバイスなので±10V固定で動作します");
            }

            //転送方式
            int aioMemTrans = aio.SetAiTransferMode(devId, 0);  //デバイスバッファ
            if (aioMemTrans != 0) {
                statusMsg(aioMemTrans, null);
                return;
            }

            //メモリ格納形式
            int aioMem = aio.SetAiMemoryType(devId, 0); //FIFO
            if (aioMem != 0) {
                statusMsg(aioMem, null);
                return;
            }

            //クロック
            int aioClk = aio.SetAiClockType(devId, 0);  //内部クロック
            if (aioClk != 0) {
                statusMsg(aioClk, null);
                return;
            }

            //変換速度
            int aioSpd = aio.SetAiSamplingClock(devId, 1000);   //1000us
            if (aioSpd != 0) {
                statusMsg(aioSpd, null);
                return;
            }
            float clock = 0;
            aio.GetAiSamplingClock(devId, out clock);
            convSpeed.Text = clock.ToString() + "μｓ";

            //開始条件
            int aioStartTrg = aio.SetAiStartTrigger(devId, 0);  //ソフトウェア
            if (aioStartTrg != 0) {
                statusMsg(aioStartTrg, null);
                return;
            }

            //停止条件
            int aioStopTrg = aio.SetAiStopTrigger(devId, 4);    //コマンド
            if (aioStopTrg != 0) {
                statusMsg(aioStopTrg, null);
                return;
            }

            /*
             * 停止条件 = 0とリピート回数 = 0でDEMO DEVICEにて実行するとこのプログラムではBSoDが発生しWindowsが停止する。
             * 恐らく想定外入力によって引き起こされるドライバのバグだと思われる。
            */

            //イベント駆動
            int aioEvent = aio.SetAiEvent(devId, (uint)this.Handle, (int)CaioConst.AIE_DATA_NUM |   //指定回数格納
                (int)CaioConst.AIE_OFERR | (int)CaioConst.AIE_SCERR | (int)CaioConst.AIE_ADERR);    //オーバーフロー、クロックエラー、AD変換エラー
            if (aioEvent != 0) {
                statusMsg(aioEvent, null);
                return;
            }

            //イベント発生サンプリング回数設定
            int aioSamplingTimes = aio.SetAiEventSamplingTimes(devId, 1000);    //1000回
            if (aioSamplingTimes != 0) {
                statusMsg(aioSamplingTimes, null);
                return;
            }
        }

        //機器のリセット
        private void resetAio() {
            int aioReset = aio.ResetAiStatus(devId);
            if (aioReset != 0) {
                statusMsg(aioReset, null);
                return;
            }
            int aioResMem = aio.ResetAiMemory(devId);
            if (aioResMem != 0) {
                statusMsg(aioResMem, null);
                return;
            }
        }

        private void getAioDeviceBtn_Click(object sender, EventArgs e) {
            caioGetDevice();
            advSetChkBtn.Checked = true;
        }

        private void initAioDeviceBtn_Click(object sender, EventArgs e) {
            caioInitDevice();
            if (devId != -1) {
                resetAio();
                chart1.Series[0].Points.Clear();
            }
            setLogger();
            if (statusLabel2.Text == "デバイスの初期化に成功しました") {
                loggingStartBtn.Enabled = true;
            } else if (statusLabel2.Text == "レンジが変更できないデバイスなので±10V固定で動作します") {
                loggingStartBtn.Enabled = true;
            } else {
                loggingStartBtn.Enabled = false;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            form2show = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            if (aioDeviceInit) aio.Exit(devId);
        }

        private void followFormChk_CheckStateChanged(object sender, EventArgs e) {
            formLocation();
        }

        private void advSetChkBtn_CheckStateChanged(object sender, EventArgs e) {
            if (advSetChkBtn.Checked) {
                this.Width = 580;
            } else {
                this.Width = 340;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            devNameLabel.Text = devNameList[comboBox1.SelectedIndex];
            xAxisListBox.Items.Clear();
            yAxisListBox.Items.Clear();
            loggingStartBtn.Enabled = false;
        }

        //ロギング開始
        private void loggingStartBtn_Click(object sender, EventArgs e) {
            Form1 mainForm = (Form1)this.Owner;
            //ラベルで動作を変える
            if (loggingStartBtn.Text == "開始") {
                resetAio();
                int aioStartLogging = aio.StartAi(devId);
                startTime = DateTime.Now;
                if (aioStartLogging != 0) {
                    statusMsg(aioStartLogging, null);
                    return;
                }
                statusMsg(0, "変換を開始しました");
                loggingStartBtn.Text = "取得中...";
                devMemoryTimer.Start();
                mainForm.logFormData(true);
            } else {
                devMemoryTimer.Stop();
                int aioStopLogging = aio.StopAi(devId);
                if (aioStopLogging != 0) {
                    statusMsg(aioStopLogging, null);
                    return;
                }
                loggingStartBtn.Text = "開始";
                statusMsg(0, "変換を停止しました");
                mainForm.logFormData(false);
            }
            //mainForm.statusLabel.Text = "test";
        }

        private void expCsvBtn_Click(object sender, EventArgs e) {
            dataProc.csvExport(convPkt);
            if (allDataExp.Checked) {
                //dataProc.csvAllExport(xyVoltListPkt, startTime);
                dataProc.csvAllExport(xyVoltList, startTime);
            }
        }

        //状態取得
        private void devMemoryTimer_Tick(object sender, EventArgs e) {
            int aiStatus = 0;
            int samplingCount = 0;
            aio.GetAiStatus(devId, out aiStatus);
            aio.GetAiSamplingCount(devId, out samplingCount);
            devStLabel.Text = aiStatus.ToString() + " + " + samplingCount.ToString();
        }

        //キューの操作(危険)
        private void queueCtrl(string x, string y) {
            if (xQueue.Count > 11) {
                xQueue.Dequeue();
            } else if (yQueue.Count > 11) {
                yQueue.Dequeue();
            } else {
                xQueue.Enqueue(x);
                xQueue.Enqueue(y);
            }
            xDataBox.Items.Clear();
            foreach (string a in xQueue) {
                xDataBox.Items.Add(a);
            }
        }

        //画像の撮影日時から電圧データの平均値を取り記録する
        public void getAverage(DateTime time) {
            //dataProc.getAverage(time, startTime, xyVoltListPkt, ref convPkt);
            dataProc.getAverage(time, startTime, xyVoltList, ref convPkt);
            averagingTimes.Text = convPkt.timeCnv.Count.ToString();
        }

        //デバッグ用デバイスリセット
        private void forceResetBtn_Click(object sender, EventArgs e) {
            int resPrc = aio.ResetProcess(devId);
            if (resPrc != 0) {
                statusMsg(resPrc, null);
            }
        }

        //イベント受け取り
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m) {
            if (m.Msg == (int)CaioConst.AIOM_AIE_DATA_NUM) {
                System.Diagnostics.Trace.WriteLine("メッセ" + m.LParam.ToString());
                int convTimes = 1000;
                float[] aioVoltData = new float[convTimes * 2];
                convertCount += (int)m.LParam;
                convTime.Text = convertCount.ToString();
                aio.GetAiSamplingDataEx(devId, ref convTimes, ref aioVoltData);
                System.Diagnostics.Trace.WriteLine("配列戻り" + convTimes.ToString());
                //dataProc.listConv(aioVoltData, ref xyVoltListPkt);
                dataProc.listConv(aioVoltData, ref xyVoltList);
            } else if (m.Msg == (int)CaioConst.AIOM_AIE_OFERR) statusMsg(1, "メモリがオーバーフローしました。");
            else if (m.Msg == (int)CaioConst.AIOM_AIE_SCERR) statusMsg(1, "サンプリングクロックエラー");
            else if (m.Msg == (int)CaioConst.AIOM_AIE_ADERR) statusMsg(1, "AD変換エラーです");
            base.WndProc(ref m);
        }
    }
}