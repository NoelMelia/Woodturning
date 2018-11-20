using System;
using Xamarin.Forms;



namespace Woodturning
{

    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
            backgroundImage();
            SetupImageOnThisPage();
            pickerOfItems();

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
        private void backgroundImage()
        {
            var assembly = typeof(ContactUs);

            string fileName = "Woodturning.Assets.Images.Objects.png";

            BackImage.Source = ImageSource.FromResource(fileName, assembly);

        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(ContactUs);

            string fileName = "Woodturning.Assets.Images.Newlogo2.png";

            newLogo2.Source = ImageSource.FromResource(fileName, assembly);
        }

        async void bowl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BowlPage());
        }

        async void biro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BiroPage());
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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}
