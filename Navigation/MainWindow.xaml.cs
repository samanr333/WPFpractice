using System;
using System.Collections.Generic;
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

namespace Navigation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Navigate());
        }
        public void Firstpage(object sender, EventArgs e)
        {
            mainFrame.Navigate(new FirstPage());
        }
        public void Secondpage(object sender, EventArgs e)
        {
            mainFrame.Navigate(new SecondPage());
        }
    }
}
