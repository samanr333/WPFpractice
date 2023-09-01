using CustomControls.Command;
using CustomControls.Controller;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace CustomControls.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindow mainWindow { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged(nameof(Gender));
                }
            }
        }

        private string displayBox;
        public string DisplayBox
        {
            get { return displayBox; }
            set
            {
                if (displayBox != value)
                {
                    displayBox = value;
                    OnPropertyChanged(nameof(DisplayBox));
                }
            }
        }
        public ICommand DisplayCommand { get; set; }
        public MainWindowViewModel()
        {
            DisplayCommand = new RelayCommand(Display, CanDisplay);
        }
        public bool CanDisplay(object obj)
        {
            return true;
        }
        public void Display(object obj)
        {
            if(!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrEmpty(Gender)) 
            {
                DisplayBox = $"Hello, {Name}! \nYour Details: \nEmail: {Email} \nGender: {Gender}";
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
