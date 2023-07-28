using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class WindowGridView : Window
    {
        public ObservableCollection<Employee> Employees { get; set; }
        public WindowGridView()
        {
            Employees = new ObservableCollection<Employee>();
            DataContext = this;
            InitializeComponent();
        }
        void AddList(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(NameEntry.Text) && !string.IsNullOrEmpty(AddressEntry.Text) && DateOnly.TryParse(DobEntry.Text, out DateOnly dob)) 
            {
                Employee employee = new Employee { Name = NameEntry.Text, Address = AddressEntry.Text, DOB = dob};
                Employees.Add(employee);
            }
            else
            {
                MessageBox.Show("Please Enter a all fields with valid values");
            }
        }
        void ClearList(object sender, RoutedEventArgs e)
        {
            Employees.Clear();
        }
        void DeleteList(object sender, RoutedEventArgs e)
        {
            var selectedEmployees = MyList.SelectedItems.Cast<Employee>().ToList();
            var result = MessageBox.Show($"Are you sure you want to delete {selectedEmployees.Count} items?", "!", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                foreach (var employee in selectedEmployees)
                {
                    Employees.Remove(employee);
                }
            }
        }
        void UpdateList(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
