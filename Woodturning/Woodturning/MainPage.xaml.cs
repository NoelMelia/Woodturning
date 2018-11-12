﻿using System;
using Xamarin.Forms;



namespace Woodturning
{

    public partial class MainPage : ContentPage
    {
        
        

        public MainPage()
        {
            InitializeComponent();
            SetupImageOnThisPage();
            pickerOfItems();

        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new Login(), this);
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
            var assembly = typeof(MainPage);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);

            //Navigation.PushAsync(new MainPage());
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



    }
}
