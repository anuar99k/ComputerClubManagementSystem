using System;
using System.Windows;
using System.Windows.Controls;

namespace ClientApp.Pages;

public partial class SignInPage : Page
{
    public SignInPage()
    {
        InitializeComponent();
    }

    private void SignInButton_OnClick(object sender, RoutedEventArgs e)
    {
        //NavigationService!.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
        NavigationService!.Navigate(new MainPage());
    }
}