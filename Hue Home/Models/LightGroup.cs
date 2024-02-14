using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hue_Home.Models
{
    public struct LightGroup
    {
        public string Name { get; set; }
        public List<DataLight> Lights { get; set; }
    }
}
