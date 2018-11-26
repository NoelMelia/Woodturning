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
	public partial class BowlPage4 : ContentPage
	{
		public BowlPage4 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage3();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BowlPage4);

            string fileName = "Woodturning.Assets.Images.Bowl.step4.PNG";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}