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
	public partial class BiroPage4 : ContentPage
	{
		public BiroPage4 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();
            SetupImageOnThisPage3();
            SetupImageOnThisPage2();
        }

        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BiroPage4);

            string fileName = "Woodturning.Assets.Images.Biro.part4p1.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }

        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BiroPage4);

            string fileName = "Woodturning.Assets.Images.Biro.part4p2.png";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BiroPage4);

            string fileName = "Woodturning.Assets.Images.Biro.part4p3.png";

            Test3.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}