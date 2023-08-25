using System;
using System.Windows;

namespace Splash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ChangeTheme(object sender,  RoutedEventArgs e)
        {
            if(DarkTheme.IsChecked == true)
            {
                Uri resourceUri = new Uri("Themes/Dark.xaml", UriKind.Relative);
                ResourceDictionary darkTheme = new ResourceDictionary();
                darkTheme.Source = resourceUri;
                Application.Current.Resources.MergedDictionaries.Add(darkTheme);
            }
            else if(DarkTheme.IsChecked == false)
            {
                Uri resourceUri = new Uri("Themes/Light.xaml", UriKind.Relative);
                ResourceDictionary lightTheme = new ResourceDictionary();
                lightTheme.Source = resourceUri;
                Application.Current.Resources.MergedDictionaries.Add(lightTheme);
            }

        }
    }
}
