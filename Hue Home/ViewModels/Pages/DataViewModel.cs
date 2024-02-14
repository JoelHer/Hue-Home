using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using Hue_Home.Models;
using Hue_Home.Views.Pages;
using Wpf.Ui.Controls;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DataViewModel : Page
    {
        public DataViewModel()
        {
            ClickLightBtn = new RelayCommand<string>(ExecuteCommands);
        }

        public ICommand ClickLightBtn { get; }

        private void ExecuteCommands(string parameter)
        {
            System.Windows.MessageBox.Show("Parameter: " + parameter);
        }
    }
}
