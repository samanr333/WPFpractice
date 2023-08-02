using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class BindingBasics : Page
    {
        public ObservableCollection<Person> PersonDetails { get; private set; }

        public BindingBasics()
        {
            
            DataContext = this;
            InitializeComponent();
        }


        private void LoadDataFromDatabase()
        {
            using (var context = new ApplicationDbContext())
            {
                var peopleFromDatabase = context.People;
                PersonDetails = new ObservableCollection<Person>(peopleFromDatabase);
            }

            myList.ItemsSource = PersonDetails;
        }
    }
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
