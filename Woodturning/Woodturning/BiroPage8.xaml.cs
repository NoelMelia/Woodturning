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
	public partial class BiroPage8 : ContentPage
	{
		public BiroPage8 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage3();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BiroPage8);

            string fileName = "Woodturning.Assets.Images.Biro.part8.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }

    }
}