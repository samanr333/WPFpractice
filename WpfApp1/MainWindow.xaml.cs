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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void showName(object sender, RoutedEventArgs e)
        {
            string name = myName.Text;
            result.Text = $"Hello, {name}";
        }
        void stackPanel(object sender, RoutedEventArgs e)
        {
            WindowStackPanel windowStackPanel = new WindowStackPanel();
            windowStackPanel.Show();
        }
        void Canvas(object sender, RoutedEventArgs e)
        {
            WindowCanvas windowCanvas = new WindowCanvas();
            windowCanvas.Show();
        }
        void DockPanel(object sender, RoutedEventArgs e)
        {
            WindowDockPanel windowDockPanel = new WindowDockPanel();
            windowDockPanel.Show();
        }
        void WrapPanel(object sender, RoutedEventArgs e)
        {
            WindowWrapPanel windowWrapPanel = new WindowWrapPanel();
            windowWrapPanel.Show();
        }
        void Avengers(object sender, RoutedEventArgs e)
        {
            WindowAvengers windowAvengers = new WindowAvengers();
            windowAvengers.Show();
        }
        void Login(object sender, RoutedEventArgs e)
        {
            WindowLogin windowLogin = new WindowLogin();
            windowLogin.Show();
        }
        void ListView(object sender, RoutedEventArgs e)
        {
            WindowListView windowListView = new WindowListView();
            windowListView.Show();            
        }
    }
}
