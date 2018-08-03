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

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("toolba", "shits active", "yes it is");
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new SubPage());
        }
    }
}
