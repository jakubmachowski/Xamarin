using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Zapisz_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<ISaveAndLoad>().SaveText("test.txt", editor.Text);
        }

        public void Odczytaj_Clicked(object sender, EventArgs e)
        {
            try
            {
                editor.Text = DependencyService.Get<ISaveAndLoad>().LoadText("test.txt");
            }
            catch
            {
                DisplayAlert("Błąd", "Błąd ładowania z pliku!", "OK");
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}
