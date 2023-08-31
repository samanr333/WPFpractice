using Prism.Mvvm;
using System.Collections.ObjectModel;
using Prism.Commands;
namespace PrismApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private bool _IsEnabled;
        public bool IsEnabled
        {
            get { return _IsEnabled; }
            set
            {
                SetProperty(ref _IsEnabled, value);
            }
        }
        private string _SelectedItem;
        public string SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                SetProperty(ref _SelectedItem, value);

            }
        }
        public ObservableCollection<string> ToDo { get; set; } 
        public ObservableCollection<string> Done { get; set; }
        public DelegateCommand<string> UpdateButton { get; set; }
        public MainWindowViewModel()
        {
            Done = new ObservableCollection<string>();
            ToDo = new ObservableCollection<string>() { "Eat", "Sleep", "Dead Lift", "Repeat" };
            UpdateButton = new DelegateCommand<string>(Execute).ObservesCanExecute(() => IsEnabled);
        }
        private void Execute(string parameter)
        {
           
            if(SelectedItem != null)
            {
                Done.Add(SelectedItem);
            }
            ToDo.Remove(SelectedItem);
        }
    }
}
