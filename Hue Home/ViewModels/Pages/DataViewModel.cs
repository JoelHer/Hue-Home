using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using Hue_Home.Models;
using Hue_Home.Views.Pages;
using Wpf.Ui.Controls;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DataViewModel : Page
    {
        public ObservableCollection<IcItem> Items { get; set; }

        public DataViewModel()
        {
            Items =
            [
                new IcItem() { Title = "Complete this WPF tutorial" },
                new IcItem() { Title = "Learn C#" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
                new IcItem() { Title = "Wash the car" },
            ];
        }
    }

    public class IcItem()
    {
        public string Title { get; set; }
    }
}
