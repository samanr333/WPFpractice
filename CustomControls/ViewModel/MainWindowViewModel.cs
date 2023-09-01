using CustomControls.Command;
using System.Windows;
using System.Windows.Input;

namespace CustomControls.ViewModel
{
    public class MainWindowViewModel
    {
        public MainWindow mainWindow { get; set; }
        public string TextBox { get; set; }
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
            MessageBox.Show("Recorded");
        }
    }
}
