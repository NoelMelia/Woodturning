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
	public partial class BiroPage11 : ContentPage
	{
		public BiroPage11 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();

        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BiroPage11);

            string fileName = "Woodturning.Assets.Images.Biro.part11.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}