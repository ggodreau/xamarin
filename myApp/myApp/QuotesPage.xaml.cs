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
        int quoteIdx = 0;

		public QuotesPage ()
		{
			InitializeComponent ();
            fontSlider.Value = 24;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // arrays are zero indexed, but this has 7 elements
            if(quoteIdx >= quoteList.Length)
            {
                quoteIdx = 0;
            }
            quoteText.Text = quoteList[quoteIdx];
            debugText.Text = string.Format("quote len: {0}, idx: {1}",
               quoteList.Length.ToString(),
               quoteIdx);
            quoteIdx += 1;
        }
    }
}