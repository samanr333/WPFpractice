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
    public partial class NavPage : Page
    {
        public NavPage()
        {
            InitializeComponent();
        }
        // For Routed Event
        public void RoutedEventClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainWindow());
        }

        // For Object Lifetime Event
        public void ObjectlifetimeEventClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ObjectLifetime());
        }

        // For Property Change Event
        public void PropertyChangeEventClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PropertyChange());
        }
    }
}
