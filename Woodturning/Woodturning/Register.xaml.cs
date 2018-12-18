using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Woodturning
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
        private const String OUTPUT_FILE = "LoginDetails.txt";
        //variables userinput, passwordinput, emailinput
        String userInput, passwordinput,emailInput;
        
        public Register()
        {
            InitializeComponent();            
            backgroundImage();
            SetupImageOnThisPage();
            pickerOfItems();
        }

        private void backgroundImage()
        {
            var assembly = typeof(Register);            

            string fileName = "Woodturning.Assets.Images.Objects.png";

            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());

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
            var assembly = typeof(Register);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);


        }
        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            dynamic emp = new JObject();
            userInput = usernameEntry.Text;
            passwordinput = passwordEntry.Text;
            emailInput = emailEntry.Text;
            
            emp.Username = userInput;
            emp.Password = passwordinput;
            emp.Email = emailInput;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filname = Path.Combine(path, OUTPUT_FILE);
            string outputString = emp.ToString();

            File.WriteAllText(filname, outputString);
            if((emp.Username==null) && (emp.Password==null) && (emp.Email == null) && (emp.Email!="@"))
            {
                messageLabel.Text = "Login failed";
            }
            else
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                Navigation.PopAsync();
                
            }

        }//OnSignUpButtonClicked

        private void Login_Button_Clicked(object sender, EventArgs e)
        {       
            Navigation.PushAsync(new Login());
        }//Login_Button_Clicked
    }
}