using System;
using System.Windows;

namespace UserInterface
{
    public partial class LoginInterface : Window
    {
        public LoginInterface()
        {
            InitializeComponent();
        }
        public void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
        public void SignUpClick(object sender, EventArgs e)
        {
            
            Register register = new Register();
            register.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
