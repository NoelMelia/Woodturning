using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woodturning;
using Login;
using WoodturningApp;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WoodturningApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            SetupImageOnThisPage();


        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(MainPage);

            string fileName = "Woodturning.Assets.Images.Newlogo.png";

            newLogo.Source = ImageSource.FromResource(fileName, assembly);
        }

        async void bowl_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BowlPage());
        }

        async void biro_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BiroPage());
        }
    }
}
