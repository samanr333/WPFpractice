using System.Windows.Navigation;

namespace GraphsAndCharts
{
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigate(new NavPage());
        }
    }
}
