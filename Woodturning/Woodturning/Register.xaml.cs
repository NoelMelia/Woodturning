using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Woodturning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
        public Register()
        {
            SetupImageOnThisPage();
            pickerOfItems();
            InitializeComponent();
        }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            var user = new User()
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text,
                Email = emailEntry.Text
            };

            // Sign up logic goes here

            var signUpSucceeded = AreDetailsValid(user);
            if (signUpSucceeded)
            {
                var rootPage = Navigation.NavigationStack.FirstOrDefault();
                if (rootPage != null)
                {
                    App.IsUserLoggedIn = true;
                    Navigation.InsertPageBefore(new MainPage(), Navigation.NavigationStack.First());
                    await Navigation.PopToRootAsync();
                }
            }
            else
            {
                messageLabel.Text = "Sign up failed";
            }
        }

        bool AreDetailsValid(User user)
        {
            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
        }
        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            MainPicker.MinimumHeightRequest = 20;
            switch (picker.SelectedIndex)
            {
                case 0:
                    Navigation.PushAsync(new Login());
                    break;
                case 1:
                    Navigation.PushAsync(new Register());
                    break;
                case 2:
                    //Navigation.PushAsync(new Login());
                    break;
                case 3:
                    //Navigation.PushAsync(new Register());
                    break;
                case 4:
                    //Navigation.PushAsync(new Login());
                    break;

                default:
                    break;



            }

        }
        private void pickerOfItems()
        {
            MainPicker.ItemsSource = new string[]
                                            {"Login",
                                             "Register",
                                            "Contact Us",
                                            "Terms",
                                            "Help"};
            //MainPicker.
        }

        private void SetupImageOnThisPage()
        {
            var assembly = typeof(MainPage);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);


        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}