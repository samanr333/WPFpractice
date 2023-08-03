using DataBinding.ViewModel;
using System.Windows;

namespace DataBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
            InitializeComponent();           
        }
    }
}
