using Microsoft.Maps.MapControl.WPF;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MapControl : Page
    {
        public MapControl()
        {
            InitializeComponent();
        }
        private void MouseClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Get the position where the mouse was clicked
            Point mousePosition = e.GetPosition(Map);
            Location pinLocation = Map.ViewportPointToLocation(mousePosition);
            // Add a pin to that position
            Pushpin pin = new Pushpin();
            MapLayer.SetPosition(pin, pinLocation);
            Map.Children.Add(pin);
            // Get the location details
            LocationDetails.Text = $"Latitude: {pinLocation.Latitude}, Longitude: {pinLocation.Longitude}";
        }
    }
}
