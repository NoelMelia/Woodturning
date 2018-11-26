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
	public partial class BowlPage1 : ContentPage
	{
		public BowlPage1 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage();

        }
        private void SetupImageOnThisPage()
        {
            var assembly = typeof(BowlPage1);

            string fileName = "Woodturning.Assets.Images.Bowl.step1.PNG";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}