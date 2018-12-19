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
        //Creating a file in the local storage to store details of username and password and email
        private const String OUTPUT_FILE = "LoginDetails.txt";
        //Object
        Constants myConstants;
        //variables
        string Username;
        string Password;

        public Login()
        {
            InitializeComponent();
            BackgroundImage();//calling the background image
            SetupImageOnThisPage();//calling the other image on page(logo)
            PickerOfItems();//Calling the picker with items         
        }//login

        //Method to make the background image on screen
        private void BackgroundImage()
        {
            //assigning the image to page
            var assembly = typeof(Login);
            //locating the image in its folder
            string fileName = "Woodturning.Assets.Images.Objects.png";
            //creating the image
            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }//background image

        // json array to hold picker options
        private void PickerOfItems()
        {
            //from the xaml page i need to assign items
            MainPicker.ItemsSource = new string[]
                                            {"Login",
                                             "Register",
                                            "Contact Us",
                                            "Terms",
                                            "Help"};

        }//PickerOfItems

        //method setting up an image on the page
        private void SetupImageOnThisPage()
        {
            //same as above but small image
            var assembly = typeof(Login);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);
        }//SetupImageOnThisPage

        //Picker method to see assign pages to the picked item
        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            MainPicker.MinimumHeightRequest = 20;
            switch (picker.SelectedIndex)
            {
                case 0://Goes to Login Page
                    Navigation.PushAsync(new Login());
                    break;
                case 1://Goes to Register Page
                    Navigation.PushAsync(new Register());
                    break;
                case 2://Goes to ContactUs Page
                    Navigation.PushAsync(new ContactUs());
                    break;
                case 3://Goes to Terms Page
                    Navigation.PushAsync(new Terms());
                    break;
                case 4://Goes to Help Page
                    Navigation.PushAsync(new Help());
                    break;
                default:
                    break;
            }//switch
        }//MainPicker_SelectedIndexChanged

        //when the register button is clicked
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());// goes to the register page
        }//OnSignUpButtonClicked

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
                            //Goes to the mainpage if details are true and correct
                            Navigation.InsertPageBefore(new MainPage(), this);
                            Navigation.PopAsync();

                        }
                        else
                        {
                            //gives an error message if false
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


        }//CLICKED

        //method to check if useranme matches input
        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Uname && user.Password == Constants.Pword;
        }//AreCredentialsCorrect
    }
}