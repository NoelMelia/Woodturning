using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Woodturning;
using Newtonsoft;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Woodturning
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        //constant
        private const String OUTPUT_FILE = "LoginDetails.txt";
        //Object
        Constants myConstants;
        //variables
        string Username;
        string Password;

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

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //get user inputs
            Username = usernameEntry.Text;
            Password = passwordEntry.Text;
           
            //load file
            try
            {
                //check if file exists
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, OUTPUT_FILE);
                string inputText = File.ReadAllText(filename);

                //Testing to see if not empty
                if (inputText != null)
                {
                    var clientLogin = JObject.Parse(inputText);

                    //make variables from JSon Array
                    for(int i = 0; i<1; i++)
                    {
                        var name = clientLogin["Username"];
                        var pass = clientLogin["Password"];
                        var email = clientLogin["Email"];

                        //check if input matches data
                        if (Username == (string)name && Password == (string)pass)
                        {
                            App.IsUserLoggedIn = true;

                            Navigation.InsertPageBefore(new MainPage(), this);
                            Navigation.PopAsync();

                        }
                        else
                        {
                            messageLabel.Text = "Login failed";
                            passwordEntry.Text = string.Empty;
                        }
                    }//for
                 
                }//if

            }
            catch
            {
                if(Constants.Uname == Username && Constants.Pword == Password)
                {
                    App.IsUserLoggedIn = true;

                    Navigation.InsertPageBefore(new MainPage(), this);
                    Navigation.PopAsync();
                }
                else
                {
                    messageLabel.Text = "Login failed";
                }
   
            }

            //var isValid = AreCredentialsCorrect(user);
            //if (isValid)
            //{
            //    App.IsUserLoggedIn = true;

            //    Navigation.InsertPageBefore(new MainPage(), this);
            //    await Navigation.PopAsync();
            //}
            //else
            //{
            //    messageLabel.Text = "Login failed";
            //    passwordEntry.Text = string.Empty;
            //}
        }//CLICKED

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Uname && user.Password == Constants.Pword;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }


    }
}