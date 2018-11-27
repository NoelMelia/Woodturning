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
	public partial class BiroPage2 : ContentPage
	{
		public BiroPage2 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();
            SetupImageOnThisPage2();
        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BiroPage2);

            string fileName = "Woodturning.Assets.Images.Biro.step2p1.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BiroPage2);

            string fileName = "Woodturning.Assets.Images.Biro.step2p2.png";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}