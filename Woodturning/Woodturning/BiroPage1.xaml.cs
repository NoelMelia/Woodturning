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
            SetupImageOnThisPage();
        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BiroPage1);

            string fileName = "Woodturning.Assets.Images.Biro.main.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}