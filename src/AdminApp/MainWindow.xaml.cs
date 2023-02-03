using System;
using System.Windows;

namespace AdminApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            MainFrame.NavigationService.Navigate(new Uri("Pages/Auth/SignInPage.xaml", UriKind.Relative));
        }
    }
}