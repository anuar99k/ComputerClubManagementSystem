using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Application.Contracts.Persistence;

namespace AdminApp.Pages.Auth;

public partial class SignInPage : Page
{
    private readonly IUnitOfWork _unitOfWork;
    
    public SignInPage(IUnitOfWork unitOfWork)
    {
        InitializeComponent();
        
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
    }

    private void LoginBtn_OnClick(object sender, RoutedEventArgs e)
    {
        // check if user exists in database
        var user = _unitOfWork.UsersRepository
            .GetAllAsync(x => x.Username == TbxLogin.Text && x.Password == TbxPassword.Password)
            .GetAwaiter().GetResult()
            .FirstOrDefault();

        if (user != null)
        {
            // redirect to main page
            NavigationService!.Navigate(new Uri("Pages/Main/MainPage.xaml", UriKind.Relative));
        }
        else
        {
            MessageBox.Show("User not found!");
        }
    }

    private void RegisterBtn_OnClick(object sender, RoutedEventArgs e)
    {
        throw new System.NotImplementedException();
    }
}