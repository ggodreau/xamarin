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

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            myLabel.Text = e.NewTextValue;
        }

        private void editCompleted(object sender, EventArgs e)
        {
            myLabel.Text = "edit completed!";
            myStack.BackgroundColor = Color.Red;
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            myLabel.Text = "entry completed!";
        }
    }
}
