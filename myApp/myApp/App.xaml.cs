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

            var imgString = new Uri("https://cdn.pixabay.com/photo/2015/05/06/16/31/andromeda-galaxy-755442_1280.jpg");
            var imgSrc = ImageSource.FromUri(imgString);

            // VERY IMPORTANT - you must wrap your root page
            // with a new NavigationPage() to have the nav bar
            MainPage = new NavigationPage(new WelcomePage())
            {
                BarBackgroundColor = Color.Brown,
                BarTextColor = Color.Yellow,
                BackgroundImage = "https://cdn.pixabay.com/photo/2015/05/06/16/31/andromeda-galaxy-755442_1280.jpg"
            };
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
