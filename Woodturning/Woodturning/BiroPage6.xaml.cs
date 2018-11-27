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
	public partial class BiroPage6 : ContentPage
	{
		public BiroPage6 ()
		{
			InitializeComponent ();
            SetupImageOnThisPage3();
            SetupImageOnThisPage2();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BiroPage6);

            string fileName = "Woodturning.Assets.Images.Biro.part6p1.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BiroPage6);

            string fileName = "Woodturning.Assets.Images.Biro.part6p2.png";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}