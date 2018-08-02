using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace myApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : MasterDetailPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = new ObservableCollection<Contact>()
            {
                new Contact(){ Name = "greg", Status = "dumb" },
                new Contact(){ Name = "leo", Status = "dumber" }
            };
		}

        async private void TextCell_Tapped(object sender, EventArgs e)
        {
            var contact = ((sender as TextCell).CommandParameter) as Contact;
            //listView.SelectedItem = null;
            this.Detail = new NavigationPage(new ContactDetailPage(contact.Name));
            // this.Detail = new ContactDetailPage(contact.Name);
            // await Navigation.PushAsync(new NavigationPage(new ContactDetailPage(contact.Name)));
        }
    }
}