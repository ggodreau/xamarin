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

            var names = new List<string>
            {
                "Greg",
                "Mosh",
                "Joyshallow"
            };

            myList.ItemsSource = names;

		}
	}
}
