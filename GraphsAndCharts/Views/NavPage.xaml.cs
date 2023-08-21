using GraphsAndCharts.Views;
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

        // For Pie Chart
        public void PieChartClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PieChart());
        }

        // For Line Graph
        public void LineGraphClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LineGraph());
        }
    }
}
