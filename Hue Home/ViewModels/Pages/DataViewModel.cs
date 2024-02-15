using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using Hue_Home.Models;
using Hue_Home.Services;
using Hue_Home.Views.Pages;
using Q42.HueApi;
using Wpf.Ui.Controls;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DataViewModel : Page, INotifyPropertyChanged
    {
        public DataViewModel()
        {
            Lights = new ObservableCollection<Light>();
            ClickLightBtn = new RelayCommand<string>(ExecuteCommands);
            GetLights();
        }

        private async void GetLights()
        {
            HueService _service = new HueService();
            var lights = await _service.GetLights();
            foreach (var light in lights)
            {
                Lights.Add(light);
            }
        }

        public ICommand ClickLightBtn { get; }

        private async void ExecuteCommands(string parameter)
        {
            HueService _service = new HueService();

            var command = new LightCommand();
            // Find Light object with id 4 in the list of lights
            bool _lState = false;
            foreach (Light light in Lights)
            {
                if (light.Id == parameter)
                {
                    _lState = !light.State.On;
                    command.On = !light.State.On;
                    // Update the light object
                    light.State.On = _lState;
                    OnPropertyChanged(nameof(Lights)); 
                }
            }
            command.Brightness = 254;
            command.TransitionTime = TimeSpan.FromSeconds(.5f);

            _service.SetLightState(parameter, command);
        }


        private ObservableCollection<Light> _lights;
        public ObservableCollection<Light> Lights
        {
            get { return _lights; }
            set
            {
                if (_lights != value)
                {
                    _lights = value;
                    OnPropertyChanged(nameof(Lights));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
