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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp1
{
    public partial class WindowDockPanel : Window
    {
        public WindowDockPanel()
        {
            InitializeComponent();
        }
        void top(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Top");
        }
        void bottom(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Bottom");
        }
        void left(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Left");
        }
        void right(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Right");
        }
        void center(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Center");
        }
    }
}
