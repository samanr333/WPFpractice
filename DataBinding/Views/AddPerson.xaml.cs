using DataBinding.ViewModel;
using System.Windows;

namespace DataBinding.Views
{
    public partial class AddPerson : Window
    {
        public AddPerson()
        {
            InitializeComponent();
            AddPersonViewModel addPersonViewModel = new AddPersonViewModel();
            this.DataContext = addPersonViewModel;
        }
    }
}
