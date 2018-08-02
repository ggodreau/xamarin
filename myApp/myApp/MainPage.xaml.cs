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
	public partial class MainPage : TabbedPage 
	{
        INavigation navigation;

		public MainPage()
		{
			InitializeComponent();
            this.BarTextColor = Color.LawnGreen;
            this.BarBackgroundColor = Color.Honeydew;
            navigation = this.Navigation;
            this.Padding = new Thickness(20, 20, 20, 20); 
		}

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await DisplayAlert("oh yea", navigation.ToString(), "ok");
        }
    }
}
