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

namespace RoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Outer button clicked");
        }
        public void Button2_Click(object sender, RoutedEventArgs f)
        {
            MessageBox.Show("Inner button clicked");
        }
        public void Elipse_Click(object sender, MouseEventArgs m)
        {
            MessageBox.Show("Elipse clicked");
        }
    }
}
