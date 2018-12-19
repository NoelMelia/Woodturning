using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Woodturning
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BiroPage1 : ContentPage
	{
		public BiroPage1 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();//calling SetupImageOnThisPage
        }
        //Method to set up image on screen
        private void SetupImageOnThisPage()
        {
            //assigning the image to page
            var assembly = typeof(BiroPage1);
            //locating the image in its folder
            string fileName = "Woodturning.Assets.Images.Biro.main.png";
            //creating the image
            Test.Source = ImageSource.FromResource(fileName, assembly);
        }//SetupImageOnThisPage

    }
}