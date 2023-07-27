using System;
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
using System.Xml.Linq;

namespace WpfApp1
{

    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }
        void submitDetails(object sender, RoutedEventArgs e)
        {
            string username = name.Text;
            string useremail = email.Text;
            string usercountry = country.Text;
            register.Text = "Registration Successful.";
            //For gender from radio button
            string gender = "None";
            if (male.IsChecked == true)
                gender = "Male";
            else if (female.IsChecked == true)
                gender = "Female";
            else if (other.IsChecked == true)
                gender = "Other";
            // For Hobbies from check box
            string? hobby1 = null;
            string? hobby2 = null;
            string? hobby3 = null;
            if (football.IsChecked == true)
                hobby1 = "Football";
            if (cricket.IsChecked == true)
                hobby2 = "Cricket";
            if (formula1.IsChecked == true)
                hobby3 = "Formula1";
            List<string> listBoxItems = new List<string>
            {
                $"Name: {username}",
                $"Email: {useremail}",
                $"Country: {usercountry}",
                $"Gender: {gender}",
                $"Hobbies: {hobby1} {hobby2} {hobby3}",

            };
            // Storing mylist to ListBox
            myList.ItemsSource = listBoxItems;

        }
    }
}
