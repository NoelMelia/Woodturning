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
	public partial class BowlPage7 : ContentPage
	{
		public BowlPage7 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();
            SetupImageOnThisPage2();
        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BowlPage7);

            string fileName = "Woodturning.Assets.Images.Bowl.step7.PNG";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BowlPage7);

            string fileName = "Woodturning.Assets.Images.Bowl.step7.PNG";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}