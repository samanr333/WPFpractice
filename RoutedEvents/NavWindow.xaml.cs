﻿using System.Windows.Navigation;

namespace RoutedEvents
{
    public partial class NavWindow : NavigationWindow
    {
        public NavWindow()
        {
            InitializeComponent();
            Navigate(new NavPage());
        }
    }
}
