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
            // Initialize live reload maybe
            #if DEBUG
            LiveReload.Init();
            #endif

            InitializeComponent();

			// MainPage = new GreetPage();
			// MainPage = new QuotesPage();
			MainPage = new StackPage();
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
