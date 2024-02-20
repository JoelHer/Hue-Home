using Q42.HueApi;
using Q42.HueApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Light = Q42.HueApi.Light;

namespace HueHome.Services
{
    public class HueService
    {

        public HueService()
        {

        }

        public async Task<IEnumerable<Light>> GetLights()
        {
            ILocalHueClient _Iclient = new LocalHueClient("192.168.178.20");
            //var appKey = await _Iclient.RegisterAsync("HueHome", Environment.MachineName);
            LocalHueClient client = await GetClient("192.168.178.20", "fnr9mCU8E3c-GCZCHSxre6V6zCAuRRDGYof4UaM2");

            IEnumerable<Light> lights = await client.GetLightsAsync();

            return lights;
        }

        public async void SetLightState(string _id, LightCommand _state)
        {
            ILocalHueClient _Iclient = new LocalHueClient("192.168.178.20");
            //var appKey = await _Iclient.RegisterAsync("HueHome", Environment.MachineName);
            LocalHueClient client = await GetClient("192.168.178.20", "fnr9mCU8E3c-GCZCHSxre6V6zCAuRRDGYof4UaM2");


            await client.SendCommandAsync(_state, new List<string> { _id });
        }

        static async Task<LocalHueClient> GetClient(string _ip, string _key)
        {
            LocalHueClient client = null;

            if (String.IsNullOrEmpty(_ip))
                return null;

            client = new LocalHueClient(_ip);
            client.Initialize(_key);

            if (!client.IsInitialized)
                return null;

            return client;
        }

    }
}
