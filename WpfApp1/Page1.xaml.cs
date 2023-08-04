using Microsoft.Win32;
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
    
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        // To navigate to main window
        void MainWindowClick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        
        // For Dialogs
        public void OpenFileClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                var pathName = openFileDialog.FileName;
                MessageBox.Show($"The selected file path is {pathName}");
            }
        }
        public void PrintClick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                MessageBox.Show("Printing document");
            }
        }
        public void SaveFileClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == true)
            {
                MessageBox.Show("Saving Files");
            }
        }

        // For Map Control
        public void MapControlClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MapControl());
        }

        // For Data Converter
        public void ValueConverterClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ValueConverter());
        }

        // For Relative Binding
        public void RelativeBindingClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RelativeBinding());
        }

    }
}
