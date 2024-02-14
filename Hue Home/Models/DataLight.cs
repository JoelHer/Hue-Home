using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue_Home.Models
{
    public struct DataLight
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public int Brightness { get; set; }
        public int Hue { get; set; }
        public int Saturation { get; set; }
    }
}
