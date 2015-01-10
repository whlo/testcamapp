using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraApp {
    class DataProcessing {

        //平均値算出
        internal void getAverage(DateTime time, DateTime startTime, List<DataPkt> xyVoltListPkt, ref ConvPkt convPkt) {
            int averageNum = 10;  //平均化する数値の個数
            double elapsedTime = unixTime(time) - unixTime(startTime);  //測定開始からの経過時間
            int index = (int)elapsedTime / 1000; //何回目の計測か
            if (elapsedTime <= 2000 || index >= xyVoltListPkt.Count) return; //経過時間が1999以下では計測が終わらずデータが無い可能性がある
            DataPkt pkt = xyVoltListPkt[index];
            int chTime = (int)elapsedTime % 1000;   //1000以下の個数(Listの中での平均化処理の開始位置)
            float x = 0;
            float y = 0;
            //elapsedTimeが9未満のときにエラーが出る！！
            if (chTime < averageNum) {
                //Listを跨ぐ必要がある場合
                DataPkt pktOld = xyVoltListPkt[index - 1];
                for (int i = chTime; i >= 0; i--) {
                    x += pkt.x[i];
                    y += pkt.y[i];
                } int lestTime =999 - averageNum - chTime;
                for (int i = 999; i >= lestTime; i--) {
                    x += pktOld.x[i];
                    y += pktOld.y[i];
                }
                x = x / averageNum;
                y = y / averageNum;
                convPkt.timeCnv.Add(time);
                convPkt.xCnv.Add(x);
                convPkt.yCnv.Add(y);
            } else if (chTime <= 1000 - averageNum) {
                //Listを跨がない場合
                for (int i = averageNum - 1; i < 0; i--) {
                    x += pkt.x[i];
                    y += pkt.y[i];
                }
                x = x / averageNum;
                y = y / averageNum;
                convPkt.timeCnv.Add(time);
                convPkt.xCnv.Add(x);
                convPkt.yCnv.Add(y);
            }
        }

        //リストから平均値算出
        internal void getAverage(DateTime time, DateTime startTime, ref ConvPkt convPkt) {
            double elapsedTime = unixTime(time) - unixTime(startTime);  //測定開始からの経過時間
            int index = (int)elapsedTime;
            convPkt.timeCnv.Add(time);
            convPkt.count.Add(index);
        }

        internal void calcAverage(DataList xyVoltList, ref ConvPkt convPkt) {
            int ave = 5;
            float x = 0;
            float y = 0;
            for (int i = 0; i < convPkt.count.Count; i++) {
                int count = convPkt.count[i];
                if (count < xyVoltList.x.Count) {
                    for (int j = count; j > count - ave + 1; j--) {
                        x += xyVoltList.x[j];
                        y += xyVoltList.y[j];
                    }
                    x = x / ave;
                    y = y / ave;
                    convPkt.xCnv.Add(x);
                    convPkt.yCnv.Add(y);
                }
            }
        }

        //カメラが動作していない時に平均値を出す
        internal void getAverageNoCam(DateTime time, DateTime startTime, DataList xyVoltList, ref ConvPkt convPkt) {
            DateTime roundedTime = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second, 0);  //ミリ秒以下切り捨て
            convPkt.timeCnv.Add(roundedTime);
            double elapsedTime = unixTime(roundedTime) - unixTime(startTime);  //測定開始からの経過時間
            int index = (int)elapsedTime;
            convPkt.count.Add(index);
        }

        //UNIX時間を計算
        private static double unixTime(DateTime date) {
            DateTime baseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, 0);
            TimeSpan timeSpan = date - baseTime;
            return timeSpan.TotalMilliseconds;
        }

        //配列をDataListに格納
        internal void listConv(float[] volt, ref DataList xyVoltList) {
            DataList lst = new DataList();
            for (int i = 0; i < volt.Length; i += 2) {
                lst.x.Add(volt[i]);
                lst.y.Add(volt[i + 1]);
            }
            xyVoltList.x.AddRange(lst.x);
            xyVoltList.y.AddRange(lst.y);         
        }

        //平均化データをcsvに保存
        internal void csvExport(ConvPkt convPkt) {
            using (var csv = new System.IO.StreamWriter("test.csv", false)) {
                for (int i = 0; i < convPkt.xCnv.Count; i++) {
                    csv.WriteLine(convPkt.timeCnv[i].ToString("HH-mm-ss-fff") + "," + convPkt.count[i].ToString() + "," + convPkt.xCnv[i] + "," + convPkt.yCnv[i]);
                }
            }
        }

        //DataList内の全データをcsv出力
        internal void csvAllExport(DataList dataList, DateTime startTime) {
            using (var csvAll = new System.IO.StreamWriter("test_all.csv", false)) {
                csvAll.WriteLine(startTime.ToString("HH-mm-ss,fff"));
                for (int i = 0; i < dataList.x.Count; i++) {
                        csvAll.WriteLine(dataList.x[i] + "," + dataList.y[i]);
                }
            }
        }
    }
}
