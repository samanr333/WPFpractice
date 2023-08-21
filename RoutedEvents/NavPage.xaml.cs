using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
