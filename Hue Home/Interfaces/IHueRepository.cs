using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue_Home.Models;

namespace Hue_Home.Interfaces
{
    public interface IHueRepository
    {
        Task<IEnumerable<DataLight>> GetLightsAsync();
        Task<LightState> GetLightStateAsync(int lightId);
        Task SetLightStateAsync(int lightId, LightState state);
    }
}
