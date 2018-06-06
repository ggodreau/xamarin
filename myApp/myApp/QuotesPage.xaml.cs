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
	public partial class QuotesPage : ContentPage
	{

        string[] quoteList = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        int quoteIdx = 1;

		public QuotesPage ()
		{
			InitializeComponent ();
            fontSlider.Value = 24;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            quoteText.Text = quoteList[quoteIdx];

        }
    }
}