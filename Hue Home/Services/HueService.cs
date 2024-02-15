using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q42.HueApi;
using Q42.HueApi.Interfaces;

namespace Hue_Home.Services
{
    public class HueService
    {
        private readonly ILocalHueClient _client;

        public HueService()
        {
            _client = new LocalHueClient("YourBridgeIpAddress");
        }

        
    }
}
