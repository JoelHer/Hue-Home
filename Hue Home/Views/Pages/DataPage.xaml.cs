// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using Hue_Home.ViewModels.Pages;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Wpf.Ui.Controls;
using Button = Wpf.Ui.Controls.Button;
using Image = Wpf.Ui.Controls.Image;

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

            AddButtonsDynamically();
        }

        private void AddButtonsDynamically()
        {
            List<string> buttonContent = new List<string> { };

            for (int i = 0; i < 20; i++)
            {
                buttonContent.Add("Light " + (i + 1).ToString());
            }

            foreach (var content in buttonContent)
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
                    Content = "asd",
                    Margin = new Thickness(0, 10, 0, 0) 
                };


                stackPanel.Children.Add(new Wpf.Ui.Controls.TextBlock { Text = content }); 
                stackPanel.Children.Add(label);

                button.Content = stackPanel;

                dynamicWrapPanel.Children.Add(button);

            }
        }
    }
}
