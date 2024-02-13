using Microsoft.Maui.Controls;
using System;

namespace NutriFlow
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Here you would typically validate the username and password
            // For the purpose of this example, let's assume validation passes
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
