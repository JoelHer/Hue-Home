// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Hue_Home.ViewModels.Pages;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Wpf.Ui.Controls;
using Hue_Home.Models;
using Button = Wpf.Ui.Controls.Button;
using Image = Wpf.Ui.Controls.Image;
using System.Configuration;

namespace Hue_Home.Views.Pages
{
    public partial class DataPage : INavigableView<DataViewModel>
    {
        public DataViewModel ViewModel { get; }

        public DataPage(DataViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();

            //AddButtonsDynamically();
        }

        private void AddButtonsDynamically()
        {
            List<DataLight> buttonContent = new List<DataLight> { };

            for (int i = 0; i < 20; i++)
            {
                DataLight _l = new DataLight();
                _l.Name = "Light " + (i + 1).ToString();
                _l.IsOn = (i%2 == 0);
                _l.Brightness = 30;
                _l.Hue = 100;
                _l.Saturation = 100;
                buttonContent.Add(_l);
            }

            foreach (DataLight content in buttonContent)
            {
                Button button = new Button
                {
                    Width = 140,
                    Height = 140,
                    Margin = new Thickness(10, 0, 0, 10)
                };

                StackPanel stackPanel = new StackPanel
                {
                    Orientation = Orientation.Vertical
                };

                Label label = new Label
                {
                    Content = (content.IsOn == false)? "Turned Off":"Turned On",
                    Margin = new Thickness(0, 10, 0, 0)
                };

                stackPanel.Children.Add(new Wpf.Ui.Controls.TextBlock { Text = content.Name });
                stackPanel.Children.Add(label);

                button.Content = stackPanel;

                button.Command = ViewModel.ClickLightBtn;
                button.CommandParameter = content.Name;


                dynamicWrapPanel.Children.Add(button);
            }
        }
    }
}
