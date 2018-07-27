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
	public partial class WelcomePage : ContentPage
	{
        Boolean _isFlipped = false;
        double _slideVal;

		public WelcomePage ()
		{
			InitializeComponent ();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage(), false);
        }

        void OnTap(object sender, EventArgs e)
        {
            _slideVal = mySlide.Value;
            if(!_isFlipped)
            {
                dum.RotationX = _slideVal;
                _isFlipped = true;
                // you need this return here and below
                return; 
            }
            dum.RotationX = 0;
            _isFlipped = false;
            return;
        }
    }
}