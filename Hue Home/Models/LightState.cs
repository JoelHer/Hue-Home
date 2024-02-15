using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue_Home.Models
{
    public class LightState
    {
        public bool On { get; set; }
        public int Brightness { get; set; }
        public int Hue { get; set; }
        public int Saturation { get; set; }
        public string Effect { get; set; }
        public float[] XY { get; set; }
        public int ColorTemperature { get; set; }
        public bool Alert { get; set; }
        public string ColorMode { get; set; }
        public string Mode { get; set; }
        public bool Reachable { get; set; }
    }
}
