using System;
using Xamarin.Forms;


namespace Woodturning
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BackgroundImage();//calling the background image
            SetupImageOnThisPage();//calling the other image on page(logo)
            PickerOfItems();//Calling the picker with items
        }//mainpage

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

        //Method to make the background image on screen
        private void BackgroundImage()
        {
            //assigning the image to page
            var assembly = typeof(Register);
            //locating the image in its folder
            string fileName = "Woodturning.Assets.Images.Objects.png";
            //creating the image
            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }//BackgroundImage

         //method setting up an image on the page
        private void SetupImageOnThisPage()
        {
            //same as above
            var assembly = typeof(MainPage);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);
        }//SetupImageOnThisPage

        //Bowl Button Clicked
        async void bowl_Clicked(object sender, EventArgs e)
        {
            //Brings user to another page when clicked
            await Navigation.PushAsync(new BowlPageMain());
        }//bowl_Clicked

        //Biro Button Clicked
        async void biro_Clicked(object sender, EventArgs e)
        {
            //Brings user to another page when clicked
            await Navigation.PushAsync(new BiroPageMain());
        }//biro_Clicked

        //Picker method to see assign pages to the picked item
        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            MainPicker.MinimumHeightRequest = 20;            
            switch (picker.SelectedIndex)//switch between picker
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
    }//MainPage
}//Woodturning
