using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace myApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var myList = new string[] { "el1", "el2" };
            string x = await DisplayActionSheet("title", "cancel", "destruct", myList );
            await DisplayAlert("foo", x, "cancel");
        }
    }
}
