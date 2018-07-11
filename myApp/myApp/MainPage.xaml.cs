using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myApp.models;

namespace myApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            myList.ItemsSource = new List<Contact>
            {
                new Contact(){ ImageUrl = "https://lh5.googleusercontent.com/-8NBn7h8s7eQ/AAAAAAAAAAI/AAAAAAAAAAs/_F1iLsrgmm0/s92-c-k-no/photo.jpg", Name="Sue", Status="Hot" },
                new Contact(){ ImageUrl = "https://lh3.googleusercontent.com/-c5cBgaRl8Og/AAAAAAAAAAI/AAAAAAAAI04/nEPGtW2ofUs/s56-c-k-no/photo.jpg", Name="Greg", Status="Hotter" },
                new Contact(){ ImageUrl = "https://scontent-dfw5-2.cdninstagram.com/vp/822a902554acd56ed68f92878fc42919/5BC5EE14/t51.2885-19/s320x320/29400710_162833257867970_5332315182041399296_n.jpg", Name="Leo", Status="Hottest" }
            };
		}
	}
}
