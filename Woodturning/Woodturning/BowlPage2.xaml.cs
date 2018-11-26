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
	public partial class BowlPage2 : ContentPage
	{
		public BowlPage2 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();
            SetupImageOnThisPage2();
            SetupImageOnThisPage3();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BowlPage2);

            string fileName = "Woodturning.Assets.Images.Bowl.step2p3.PNG";

            Test3.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BowlPage2);

            string fileName = "Woodturning.Assets.Images.Bowl.step2p2.PNG";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }

        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BowlPage2);

            string fileName = "Woodturning.Assets.Images.Bowl.step2p1.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}