﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraApp {
    class DataProcessing {
        //平均値算出
        internal void getAverage(DateTime time, DateTime startTime, List<DataPkt> xyVoltList, ref ConvPkt convPkt) {
            int convNum = 100;  //平均化する数値の個数
            double elapsedTime = unixTime(time) - unixTime(startTime);  //測定開始からの経過時間
            int index = (int)elapsedTime / 1000; //何回目の計測か
            if (elapsedTime <= 2000 || index >= xyVoltList.Count) return; //経過時間が1999以下では計測が終わらずデータが無い可能性がある
            DataPkt pkt = xyVoltList[index];
            int chTime = (int)elapsedTime % 1000;   //1000以下の個数(Listの中での平均化処理の開始位置)
            float x = 0;
            float y = 0;
            //elapsedTimeが9未満のときにエラーが出る！！
            if (chTime < convNum) {
                //Listを跨ぐ必要がある場合
                DataPkt pktOld = xyVoltList[index - 1];
                for (int i = chTime; i >= 0; i--) {
                    x += pkt.x[i];
                    y += pkt.y[i];
                } int lestTime =999 - convNum - chTime;
                for (int i = 999; i >= lestTime; i--) {
                    x += pktOld.x[i];
                    y += pktOld.y[i];
                }
                x = x / convNum;
                y = y / convNum;
                convPkt.timeCnv.Add(time);
                convPkt.xCnv.Add(x);
                convPkt.yCnv.Add(y);
            } else if (chTime <= 1000 - convNum) {
                //Listを跨がない場合
                for (int i = convNum - 1; i < 0; i--) {
                    x += pkt.x[i];
                    y += pkt.y[i];
                }
                x = x / convNum;
                y = y / convNum;
                convPkt.timeCnv.Add(time);
                convPkt.xCnv.Add(x);
                convPkt.yCnv.Add(y);
            }
        }

        //UNIX時間を計算
        private static double unixTime(DateTime date) {
            DateTime baseTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, 0);
            TimeSpan timeSpan = date - baseTime;
            return timeSpan.TotalMilliseconds;
        }

        //配列を2次元Listに格納
        internal void listConv(float[] volt, ref List<DataPkt> xyVoltList) {
            DataPkt pkt = new DataPkt();
            for (int i = 0; i < volt.Length; i += 2) {
                pkt.x[i / 2] = volt[i];
                pkt.y[i / 2] = volt[i + 1];
            }
            xyVoltList.Add(pkt);
        }

        //csv出力用
        internal void csvExport(ConvPkt convPkt) {
            using (var csv = new System.IO.StreamWriter("test.csv", false)) {
                for (int i = 0; i < convPkt.timeCnv.Count; i++) {
                    csv.WriteLine(convPkt.timeCnv[i] + "," + convPkt.xCnv[i] + "," + convPkt.yCnv[i]);
                }
            }
        }
    }
}
