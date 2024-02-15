using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Hue_Home.Interfaces;
using Hue_Home.Models;

namespace Hue_Home.Repositories
{
    public class HueRepository : IHueRepository
    {

        public HueRepository()
        {
            
        }

        public Task<IEnumerable<DataLight>> GetLightsAsync()
        {
            Console.WriteLine("GetLightsAsync");

            var dummyLights = new List<DataLight>();

            DataLight _l = new DataLight();
            _l.Name = "Living Room";
            _l.IsOn = true;
            _l.Brightness = 100;
            _l.Hue = 100;
            _l.Saturation = 100;
            dummyLights.Add(_l);


            return Task.FromResult<IEnumerable<DataLight>>(dummyLights);
        }


        public Task<LightState> GetLightStateAsync(int lightId)
        {
            throw new NotImplementedException();
        }

        public Task SetLightStateAsync(int lightId, LightState state)
        {
            throw new NotImplementedException();
        }
    }
}
