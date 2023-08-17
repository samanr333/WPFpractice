using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RoutedEvents
{
    public partial class ObjectLifetime : Page
    {
        public ObjectLifetime()
        {
            InitializeComponent();
        }
        public void Page_Initialized(object sender, System.EventArgs e)
        {
            MessageBox.Show("Initialized...");
        }
        public async void Page_Loaded(object sender, System.EventArgs e)
        {
            await Task.Delay(1000);
            DisplayText.Text = "Loading";
            await Task.Delay(1000);
            DisplayText.Text = "Loaded";
            DisplayRectangle.Fill = Brushes.Green;
        }

        private void Button_Unloaded(object sender, RoutedEventArgs e)
        {

        }
        public void Page_Unloaded(object sender, System.EventArgs e)
        {
            DisplayRectangle.Fill = Brushes.Red;
            DisplayText.Text = "Unloaded";
        }
        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            Page_Unloaded(sender, e);
        }
    }
}
