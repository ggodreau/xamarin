using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using static myApp.AppConstants;

namespace myApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{

        //string[] imgList = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int curPhoto = 0;
        string baseUrl = "http://placebacon.net/1920/1080?image=";
        
		public ImagePage ()
		{
			InitializeComponent ();
            btnLeft.Image = (FileImageSource) ImageSource.FromFile("arrow_left.png");
            btnRight.Image = (FileImageSource) ImageSource.FromFile("arrow_right.png");
		}

        private void btnLeft_Clicked(object sender, EventArgs e)
        {
            curPhoto -= 1;
            if (curPhoto < 0)
                curPhoto = 9;
            var source = new Uri(baseUrl + curPhoto.ToString());
            mainPhoto.Source = UriImageSource.FromUri(source);
        }

        private void btnRight_Clicked(object sender, EventArgs e)
        {
            curPhoto += 1;
            if (curPhoto >= 9)
                curPhoto = 0;
            var source = new Uri(baseUrl + curPhoto.ToString());
            mainPhoto.Source = UriImageSource.FromUri(source);
    }
}