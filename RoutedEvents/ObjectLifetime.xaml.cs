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
/*        public void Page_Unloaded(object sender, System.EventArgs e)
        {
            DisplayRectangle.Fill = Brushes.Red;
            DisplayText.Text = "Unloaded";
        }*/
    }
}
