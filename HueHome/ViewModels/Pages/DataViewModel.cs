using HueHome.Models;
using HueHome.Services;
using Q42.HueApi;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media;
using Wpf.Ui.Controls;

namespace HueHome.ViewModels.Pages
{
    public partial class DataViewModel : ObservableObject
    {
        public DataViewModel()
        {
            
            GetLights();
        }

        private ObservableCollection<LightTest> _lights = new ObservableCollection<LightTest>();
        public ObservableCollection<LightTest> Lights
        {
            get { return _lights; }
            set
            {
                _lights = value;
                OnPropertyChanged(nameof(Lights));
            }
        }


        private async void GetLights()
        {
            HueService _service = new HueService();
            var _lights = await _service.GetLights();
            
            foreach (var light in _lights)
            {
                LightTest _l = new LightTest();
                _l.Id = light.Id;
                _l.Name = light.Name;
                _l.State = light.State;
                Lights.Add(_l);
                
            }
            Console.WriteLine("Lights: " + Lights.Count);
        }

        [RelayCommand]
        private Task ClickLightBtn(string parameter)
        {
            HueService _service = new HueService();

            var command = new LightCommand();
            bool _lState = false;
            
            foreach (LightTest light in Lights)
            {
                if (light.Id == parameter)
                {
                    _lState = !light.State.On;
                    command.On = !light.State.On;
                    // Update the light object
                    light.State.On = _lState;
                }
            }
            
            command.Brightness = 254;
            command.TransitionTime = TimeSpan.FromSeconds(.5f);

            _service.SetLightState(parameter, command);
            return Task.CompletedTask;
        }

        public class LightTest
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string ModelId { get; set; }
            public string ManufacturerName { get; set; }
            public string UniqueId { get; set; }
            public string SwVersion { get; set; }
            public State State { get; set; }
        }
    }
}
