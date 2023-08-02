using DataBinding.Commands;
using DataBinding.Models;
using DataBinding.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DataBinding.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Person> People { get; set; }
        public ICommand ShowWindowCommand { get; set; }
        public MainViewModel()
        {
            People = Manager.GetPeople();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
        }
    }
}
