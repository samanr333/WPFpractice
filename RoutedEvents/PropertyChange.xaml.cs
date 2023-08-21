using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoutedEvents
{
    
    public partial class PropertyChange : Page
    {
        public PropertyChange()
        {            
            InitializeComponent();
            Person person = new Person();
            this.DataContext = person;
        }
    }
    public class Person:INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    OnPropertyChanged(FirstName);
                    OnPropertyChanged(FullName);
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    OnPropertyChanged(LastName);
                    OnPropertyChanged(FullName);
                }
            }
        }
        public string FullName
        {
            get
            {
                return fullName = firstName + " " + lastName;
            }
            set
            {
                if(fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged(FullName);
                }
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
