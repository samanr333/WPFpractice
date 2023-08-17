using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RoutedEvents
{
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
        public void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inner button clicked");
        }
        public void Elipse2_Click(object sender, MouseEventArgs e)
        {
            this.Title = "Elipse has changed the title";
        }
        public void Elipse1_Move(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse moved to green elipse");
        }

        // Attached Events
        public void Mouse_Enter(object sender, MouseEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            panel.Background = Brushes.Bisque;
        }
        public void Mouse_Leave(object sender, MouseEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            panel.Background = Brushes.Transparent;
        }
    }
}
