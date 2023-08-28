using System;
using System.Windows;
using System.Windows.Controls;

namespace LifeCycle
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        public void SecondClick(object sender, EventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            mainWindow.MyFrame.Navigate(new Second());
        }
    }
}
