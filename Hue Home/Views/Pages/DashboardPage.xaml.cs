using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Hue_Home.ViewModels.Pages;
using Wpf.Ui.Controls;
using Button = Wpf.Ui.Controls.Button;

namespace Hue_Home.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
