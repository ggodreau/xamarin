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
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
			InitializeComponent ();
            mySlider.Value = 0.5;
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            myLabel.Text = string.Format("Newest value is: {0:F2}", e.NewValue);
        }
    }
}