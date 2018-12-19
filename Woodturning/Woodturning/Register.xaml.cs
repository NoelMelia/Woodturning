using Newtonsoft.Json.Linq;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Woodturning
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
        //Creating a file in the local storage to store details of username and password and email
        private const String OUTPUT_FILE = "LoginDetails.txt";
        //variables userinput, passwordinput, emailinput
        String userInput, passwordinput,emailInput;
        
        //Main Register that call all the methods
        public Register()
        {
            InitializeComponent();            
            BackgroundImage();//calling the background image
            SetupImageOnThisPage();//calling the other image on page(logo)
            PickerOfItems();//Calling the picker with items
        }//register

        //Method to make the background image on screen
        private void BackgroundImage()
        {
            //assigning the image to page
            var assembly = typeof(Register);
            //locating the image in its folder
            string fileName = "Woodturning.Assets.Images.Objects.png";
            //creating the image
            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }//background image

        //checking to see if the user has correct details entered
        bool AreDetailsValid(User user)
        {//making sure the input of each is not empty
            return (!string.IsNullOrWhiteSpace(user.Username) && !string.IsNullOrWhiteSpace(user.Password) && !string.IsNullOrWhiteSpace(user.Email) && user.Email.Contains("@"));
        }//AreDetailsValid

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
            var assembly = typeof(Register);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);
        }//SetupImageOnThisPage

        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // Creating a dynamic dictionary.
            dynamic emp = new JObject();
            userInput = usernameEntry.Text;
            passwordinput = passwordEntry.Text;
            emailInput = emailEntry.Text;
            // Adding new dynamic properties. 
            // The TrySetMember method is called.
            emp.Username = userInput;
            emp.Password = passwordinput;
            emp.Email = emailInput;

            //Path where the info will go
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filname = Path.Combine(path, OUTPUT_FILE);
            string outputString = emp.ToString();
            //write the info to file
            File.WriteAllText(filname, outputString);
            //checks to see if all tasks are meet
            if((emp.Username==null) && (emp.Password==null) && (emp.Email == null) && (emp.Email!="@"))
            {
                //gives an error message if false
                messageLabel.Text = "Login failed";
            }//if
            else
            {
                Console.WriteLine(
                "Username: " + emp.Username);
                //Goes to the mainpage if details are true and correct
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                Navigation.PopAsync();
            }//else

        }//OnSignUpButtonClicked

        //when the login button is clicked
        private void Login_Button_Clicked(object sender, EventArgs e)
        {       
            Navigation.PushAsync(new Login());// goes to the login page
        }//Login_Button_Clicked
    }
}