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
    }
}
