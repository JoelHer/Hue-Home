using System.Windows.Input;

namespace Hue_Home.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        public DashboardViewModel()
        {
            IncrementCounterCommand = new RelayCommand<string>(ExecuteCommands);
            FirstName = "John";
            LastName = "Pork";
        }

        public ICommand IncrementCounterCommand { get; }

        private void ExecuteCommands(string parameter)
        {
            MessageBox.Show("Parameter: " + parameter);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
