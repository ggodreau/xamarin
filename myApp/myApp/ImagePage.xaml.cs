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
            // pulls from local resource (folder 'images' in PCL)
            myImage.Source = ImageSource.FromResource("myApp.images.troll.jpg");
		}
	}
}