using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GraphsAndCharts
{
    public partial class NavPage : Page
    {
        public NavPage()
        {
            InitializeComponent();
        }
        // For Bar Graph
        public void BarGraphClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BarGraph());
        }
    }
}
