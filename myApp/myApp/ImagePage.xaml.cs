using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            var imageSource = new UriImageSource { Uri = new Uri("https://quidsup.net/wallpaper/abstract/the-cube-1920x1080-wallpaper-5189.jpg") };
            // disables default (24h) caching on the device
            imageSource.CachingEnabled = false;
            // sets the caching that does happen to only cache for 1h
            imageSource.CacheValidity = TimeSpan.FromHours(1);
            // bind the imageSource object to the myImage XAML x:name element
            myImage.Source = imageSource;

		}
	}
}