using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace myApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // VERY IMPORTANT - you must wrap your root page
            // with a new NavigationPage() to have the nav bar
            MainPage = new NavigationPage(new WelcomePage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
