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
	public partial class BowlPage8 : ContentPage
	{
		public BowlPage8 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage3();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BowlPage8);

            string fileName = "Woodturning.Assets.Images.Bowl.step8.PNG";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}