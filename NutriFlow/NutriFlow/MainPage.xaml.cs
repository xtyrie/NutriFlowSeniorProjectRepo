using Microsoft.Maui.Controls;
using System;

namespace NutriFlow
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler for the Log In button
        private async void OnLogInClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("LoginPage");

        }

        // Event handler for the Sign Up button
        private async void OnSignUpClicked(object sender, EventArgs e)
        {
            // Navigate to the Sign Up page
            // For example: await Shell.Current.GoToAsync("//SignUpPage");
            // Implement the logic to navigate to the Sign Up page
        }
    }
}
