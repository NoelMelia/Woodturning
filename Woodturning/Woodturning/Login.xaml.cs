using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Woodturning;

namespace Woodturning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        public Login()
        {
            InitializeComponent();
            backgroundImage();
            SetupImageOnThisPage();
            pickerOfItems();

        }

        private void backgroundImage()
        {
            var assembly = typeof(Login);

            string fileName = "Woodturning.Assets.Images.Objects.png";

            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }
        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new BowlPage(), this);
            await Navigation.PopAsync();
        }

        private void pickerOfItems()
        {
            MainPicker.ItemsSource = new string[]
                                            {"Login",
                                             "Register",
                                            "Contact Us",
                                            "Terms",
                                            "Help"};
        }

        private void SetupImageOnThisPage()
        {
            var assembly = typeof(Login);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);

            
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
                    Navigation.PushAsync(new ContactUs());
                    break;
                case 3:
                    Navigation.PushAsync(new Terms());
                    break;
                case 4:
                    Navigation.PushAsync(new Help());
                    break;

                default:
                    break;



            }

        }


        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                await DisplayAlert("Welcome", Convert.ToString(usernameEntry), "OK");
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}