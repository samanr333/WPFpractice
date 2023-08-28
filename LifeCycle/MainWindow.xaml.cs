using System;
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
            MyFrame.Navigate(new Home());
        }

        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Window loaded");
        }

        private void MainWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            MessageBox.Show("Size of window has changed");
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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            SizeButton.Content = "Button Clicked!";
            Width += 100;
        }
    }
}
