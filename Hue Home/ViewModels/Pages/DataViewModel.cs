using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using Hue_Home.Interfaces;
using Hue_Home.Models;
using Hue_Home.Views.Pages;
using Wpf.Ui.Controls;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DataViewModel : Page
    {
        private readonly IHueRepository _hueRepository;
        private ObservableCollection<DataLight> _lights;

        public DataViewModel(IHueRepository hueRepository)
        {
            _hueRepository = hueRepository;

            LightsName = "Lights:";
            ClickLightBtn = new RelayCommand<string>(ExecuteCommands);

            _lights = new ObservableCollection<DataLight>(); // Initialize as ObservableCollection

            DataLight _l = new DataLight();
            _l.Name = "Living Room";
            _l.IsOn = true;
            _l.Brightness = 100;
            _l.Hue = 100;
            _l.Saturation = 100;
            _lights.Add(_l);

            // Initialize lights collection
            Initialize();
        }

        private async void Initialize()
        {
            // Retrieve lights asynchronously
            var lights = await _hueRepository.GetLightsAsync();
            foreach (var light in lights)
            {
                _lights.Add(light); // Add each light to the ObservableCollection
            }
            Console.WriteLine(lights);
        }

        public ObservableCollection<DataLight> Lights => _lights; // Expose as ObservableCollection

        public String LightsName { get; set; }

        public ICommand ClickLightBtn { get; }

        private void ExecuteCommands(string parameter)
        {
            System.Windows.MessageBox.Show("Parameter: " + parameter);
        }
    }
}
