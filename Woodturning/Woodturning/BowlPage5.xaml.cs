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
	public partial class BowlPage5 : ContentPage
	{
		public BowlPage5 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage3();
            SetupImageOnThisPage2();
        }

        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BowlPage5);

            string fileName = "Woodturning.Assets.Images.Bowl.step5.PNG";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }

        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BowlPage5);

            string fileName = "Woodturning.Assets.Images.Bowl.step5p1.PNG";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}