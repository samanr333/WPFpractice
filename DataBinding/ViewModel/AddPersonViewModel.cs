using DataBinding.Commands;
using DataBinding.Models;
using System.Windows.Input;

namespace DataBinding.ViewModel
{
    public class AddPersonViewModel
    {
        public ICommand AddPersonCommand { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public double? Number { get; set; }
        public AddPersonViewModel()
        {
            AddPersonCommand = new RelayCommand(AddPerson, CanAddPerson);
        }

        private bool CanAddPerson(object obj)
        {
            return true;
        }
        private void AddPerson(object obj)
        {
            Manager.AddPerson(new Person() { Name = Name, Address = Address, Number = (double)Number });
        }
    }
}
