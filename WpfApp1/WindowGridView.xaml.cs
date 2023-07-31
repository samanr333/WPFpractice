using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            // Adding Employees
            Employees.Add(new Employee { Name = "Bibek",Address = "Bhaktapur", DOB = new DateOnly(2001, 5, 15), Salary = 20000 });
            Employees.Add(new Employee { Name = "Sachin", Address = "Kathmandu", DOB = new DateOnly(1999, 3, 25), Salary = 18500 });
            Employees.Add(new Employee { Name = "Sanju", Address = "Chitwan", DOB = new DateOnly(1998, 4, 16), Salary = 25000 });
            Employees.Add(new Employee { Name = "Pranish", Address = "Hetauda", DOB = new DateOnly(2000, 3, 28), Salary = 15000 });
            Employees.Add(new Employee { Name = "Saman", Address = "Kathmandu", DOB = new DateOnly(1999, 3, 25), Salary = 20000 });
            DataContext = this;
            InitializeComponent();
        }
        void AddList(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameEntry.Text) && !string.IsNullOrWhiteSpace(AddressEntry.Text) && DateOnly.TryParse(DobEntry.Text, out DateOnly dob ) && double.TryParse(SalaryEntry.Text, out double salary))
            {
                Employee employee = new Employee { Name = NameEntry.Text, Address = AddressEntry.Text, DOB = dob, Salary = salary };
                Employees.Add(employee);
                NameEntry.Text = "";
                AddressEntry.Text = "";
                DobEntry.Text = "";
                SalaryEntry.Text = "";
            }
            else
            {
                MessageBox.Show("Please Enter all fields with valid values");
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
            if (MyList.SelectedItem is Employee employee)
            {
                employee.Name = NameEntry.Text;
                employee.Address = AddressEntry.Text;
                employee.DOB = DateOnly.Parse(DobEntry.Text);
                employee.Salary = Double.Parse(SalaryEntry.Text);
                MyList.Items.Refresh();
                //Parse just parses the data but Tryparse parse the data and stores the value in a variable and if there is exception it stores a boolean value.
            }
        }
        public void ListChange(object sender, SelectionChangedEventArgs e)
        {
            if (MyList.SelectedItem is Employee employee)
            {
                NameEntry.Text = employee.Name;
                AddressEntry.Text = employee.Address;
                DobEntry.Text = employee.DOB.ToString();
                SalaryEntry.Text = employee.Salary.ToString();
            }
        }
        public void SearchList(object sender, RoutedEventArgs e)
        {
            var searchItem = SearchBox.Text.ToLower();
            List<Employee> filteredList = Employees.Where(e => e.Name.ToLower().Contains(searchItem) || e.Address.ToLower().Contains(searchItem))
                .ToList();

            MyList.ItemsSource = filteredList;
        }
        public void GroupList(object sender, RoutedEventArgs e)
        {
            CollectionView viewEmployee = (CollectionView)CollectionViewSource.GetDefaultView(MyList.ItemsSource);
            PropertyGroupDescription groupDescriptionEmployee = new PropertyGroupDescription("Address");
            viewEmployee.GroupDescriptions.Add(groupDescriptionEmployee);
        }
        public async void SortList(object sender, RoutedEventArgs e)
        {
            string sortBy = SortBy.Text;
            CollectionView viewEmployee = (CollectionView)CollectionViewSource.GetDefaultView(MyList.ItemsSource);
            if (sortBy == "Name")
            {
                SortDescription sortDescriptionEmployee = new SortDescription("Name", ListSortDirection.Ascending);
                viewEmployee.SortDescriptions.Add(sortDescriptionEmployee);
            }
            if (sortBy == "Salary")
            {
                SortDescription sortDescriptionEmployee = new SortDescription("Salary", ListSortDirection.Ascending);
                viewEmployee.SortDescriptions.Add(sortDescriptionEmployee);
            }


        }
        public void ResetList(object sender, RoutedEventArgs e)
        {
            CollectionView viewEmployee = (CollectionView)CollectionViewSource.GetDefaultView(MyList.ItemsSource);
            viewEmployee.GroupDescriptions.Clear();
            viewEmployee.SortDescriptions.Clear();
        }
    }
}
