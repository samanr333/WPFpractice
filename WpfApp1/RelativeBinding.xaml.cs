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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for RelativeBinding.xaml
    /// </summary>
    public partial class RelativeBinding : Page
    {
        public string? myName { get; set; }
        /*public void displayClick(object sender, RoutedEventArgs e)
        {
            string DisplayName = textName.Text;
        }*/
        public RelativeBinding()
        {
            InitializeComponent();
        }
        public void displayClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textName.Text))
            {
                myName = textName.Text;
                DataContext = this;
            }
            myName = null;
        }
    }

}
