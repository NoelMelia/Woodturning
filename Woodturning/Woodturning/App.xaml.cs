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
            MainPage = new NavigationPage(new MainPage());

            /*if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new NavigationPage(new MainPage());
            }*/
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
