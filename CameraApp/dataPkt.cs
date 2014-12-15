using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraApp {
    class DataPkt {
        public float[] x = new float[1000];
        public float[] y = new float[1000];
    }
    class ConvPkt {
        public List<DateTime> timeCnv = new List<DateTime>();
        public List<float> xCnv = new List<float>();
        public List<float> yCnv = new List<float>();
        internal void clear() {
            timeCnv.Clear();
            xCnv.Clear();
            yCnv.Clear();
        }
    }
}
