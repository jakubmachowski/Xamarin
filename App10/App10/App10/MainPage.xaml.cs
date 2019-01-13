using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection dbconn;

        public MainPage()
        {
            InitializeComponent();

            var path = DependencyService.Get<IFileHelper>().GetLocalFilePath("database.db");
            dbconn = new SQLiteConnection(path);

            dbconn.CreateTable<Fruit>();

            button1.Clicked += Button1_Clicked;
            button2.Clicked += Button2_Clicked;
            button3.Clicked += Button3_Clicked;
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            dbconn.Delete(list.SelectedItem);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            list.ItemsSource = dbconn.Table<Fruit>().ToList();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            var fr = new string[] { "Apple", "Banana", "Berry", "Raspberry", "Strawberry", "Watermelon", "Plum", "Pear" };

            Random r = new Random();
            for (int i = 0; i < r.Next(10); i++)
            {
                var name = fr[r.Next(fr.Length)];
                dbconn.Insert(new Fruit { IsSweet = r.Next(2) == 1 ? true : false, Name = name });
            }
        }
    }
}
