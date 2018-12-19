using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Woodturning
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        public App()
            
        {
            InitializeComponent();
            
            //if the user ist logged in then go to login page 
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            //otherwise go to homepage
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }
        }

        
        
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }




    }

}
