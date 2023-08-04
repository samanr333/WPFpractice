using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class RelativeBinding : Page
    {
        public string myName { get; set; }
        public string myNullName { get; set; }
        public RelativeBinding()
        {
            myNullName = null;
            InitializeComponent();
        }
        public void displayClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textName.Text))
            {
                myName = textName.Text;
                DataContext = this;
            }
        }
    }
}
