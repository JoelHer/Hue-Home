using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using Hue_Home.Models;
using Hue_Home.Views.Pages;
using Wpf.Ui.Controls;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DataViewModel : Page
    {
        public DataViewModel()
        {
            Lights = new List<DataLight>();

            ClickLightBtn = new RelayCommand<string>(ExecuteCommands);

            DataLight _l = new DataLight();
            _l.Name = "Living Room";
            _l.IsOn = true;
            _l.Brightness = 100;
            _l.Hue = 100;
            _l.Saturation = 100;
            Lights.Add(_l);
            
        }


        public ICommand ClickLightBtn { get; }

        private void ExecuteCommands(string parameter)
        {
            System.Windows.MessageBox.Show("Parameter: " + parameter);
        }

        public List<DataLight> Lights { get; set; }
    }
}
