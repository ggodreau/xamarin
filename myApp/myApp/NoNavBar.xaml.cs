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
	public partial class NoNavBar : ContentPage
	{
		public NoNavBar ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnLabelTap(object sender, System.EventArgs e)
        {
            myStack.BackgroundColor = Color.BlueViolet;
        }
    }
}