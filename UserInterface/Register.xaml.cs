using System;
using System.Windows;

namespace UserInterface
{

    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        public void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            LoginInterface login = new LoginInterface();
            login.Show();
            Close();
        }
    }
}
