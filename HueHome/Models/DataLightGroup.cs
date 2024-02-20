using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueHome.Models
{
    public struct DataLightGroup    
    {
        public string Name { get; set; }
        public List<DataLight> Lights { get; set; }
    }
}
