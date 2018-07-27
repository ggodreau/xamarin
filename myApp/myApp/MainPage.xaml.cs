using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using myApp.models;

namespace myApp
{
	public partial class MainPage : ContentPage
	{
        private ObservableCollection<Contact> _contacts;
        private string _searchText;

        public void AddContacts(IList<Contact> list)
        {
            list.ToList().ForEach(_contacts.Add);
        }

        private void SearchContacts(string searchText = null)
        {
            myList.ItemsSource = _contacts.Where(b => b.Name.ToUpper().StartsWith(searchText.ToUpper()));
        }

		public MainPage()
		{
			InitializeComponent();

            _contacts = new ObservableCollection<Contact>()
            {
                new Contact(){ ImageUrl = "https://lh5.googleusercontent.com/-8NBn7h8s7eQ/AAAAAAAAAAI/AAAAAAAAAAs/_F1iLsrgmm0/s92-c-k-no/photo.jpg",
                    Name ="Sue", Status="Hot" },
                new Contact(){ ImageUrl = "https://lh3.googleusercontent.com/-c5cBgaRl8Og/AAAAAAAAAAI/AAAAAAAAI04/nEPGtW2ofUs/s56-c-k-no/photo.jpg",
                    Name ="Greg", Status="Hotter" },
                new Contact(){ ImageUrl = "https://scontent-dfw5-2.cdninstagram.com/vp/822a902554acd56ed68f92878fc42919/5BC5EE14/t51.2885-19/s320x320/29400710_162833257867970_5332315182041399296_n.jpg",
                    Name ="Leo", Status="On Fire" }
            };

            myList.ItemsSource = _contacts;
		}

        private void myList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var fuckshit = e.Item as Contact;
            //DisplayAlert("tapped", fuckshit.Name + myList.IsVisible, "whatever");
            //for (int i = 0; i < 360; i = i + 10)
            //{
            //    myList.Rotation = i;
            //    System.Threading.Thread.Sleep(30);
            //}
            myList.RotationX = 30;
        }

        private void myList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var fuckshit = e.SelectedItem as Contact;
            //DisplayAlert("selected", fuckshit.Name, "whatever");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            DisplayAlert("Call Item", e.GetType().ToString(), "Yep");
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            DisplayAlert("Call Item", contact.Name, "Yep");
            _contacts.Remove(contact);
        }

        private void myList_Refreshing(object sender, EventArgs e)
        {
            AddContacts(new List<Contact>()
                {
                new Contact() { ImageUrl = "https://lh5.googleusercontent.com/-8NBn7h8s7eQ/AAAAAAAAAAI/AAAAAAAAAAs/_F1iLsrgmm0/s92-c-k-no/photo.jpg",
                    Name = "Sue", Status = "Hot" },
                new Contact() { ImageUrl = "https://lh3.googleusercontent.com/-c5cBgaRl8Og/AAAAAAAAAAI/AAAAAAAAI04/nEPGtW2ofUs/s56-c-k-no/photo.jpg",
                    Name = "Greg", Status = "Hotter" }
                });

                
            // System.Threading.Thread.Sleep(3000);
            // DisplayAlert("shits refreshing!", "omg!", "shit!!");
            myList.IsRefreshing = false;

        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //DisplayAlert("results are", e.NewTextValue, "go awai");
            //SearchContacts("Greg");
            SearchContacts(_searchText);
        }

        private void mySearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(e.NewTextValue.Length == 0) { myList.ItemsSource = _contacts; }
            _searchText = e.NewTextValue;
        }
    }
}
