using System.ComponentModel;
using System.Windows;

namespace LifeCycle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindowLoaded;
            SizeChanged += MainWindowSizeChanged;
            Closing += MainWindowClose;
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window loaded");
            MyFrame.Navigate(new Home());
        }

        private void MainWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Height of window has changed");
        }

        private void MainWindowClose(object sender, CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to save before closing?", "Closing", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Saving Data");
            }
        }
        
        private void MainWindowUnloaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window Unloading");
        }
        public void SizeClick(object sender, RoutedEventArgs e)
        {
            Modal modal = new Modal();
            if (modal.ShowDialog() == true)
            {
                Height += 100;
            }  
        }
    }
}
