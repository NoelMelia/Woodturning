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
    public partial class BiroPage3 : ContentPage
    {
        public BiroPage3()
        {
            InitializeComponent();
            SetupImageOnThisPage3();
            SetupImageOnThisPage2();
        }
        private void SetupImageOnThisPage3()
        {
            var assembly = typeof(BiroPage3);

            string fileName = "Woodturning.Assets.Images.Biro.part3p1.png";

            Test.Source = ImageSource.FromResource(fileName, assembly);
        }
        private void SetupImageOnThisPage2()
        {
            var assembly = typeof(BiroPage3);

            string fileName = "Woodturning.Assets.Images.Biro.part3p2.png";

            Test2.Source = ImageSource.FromResource(fileName, assembly);
        }
    }
}