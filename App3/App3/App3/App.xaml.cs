using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            ((MainPage)MainPage).Odczytaj_Clicked(null, null);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            ((MainPage)MainPage).Zapisz_Clicked(null, null);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            ((MainPage)MainPage).Odczytaj_Clicked(null, null);
        }
    }
}
