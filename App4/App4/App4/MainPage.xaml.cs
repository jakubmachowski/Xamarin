using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection dbconn;
        public MainPage()
        {
            InitializeComponent();
            
            var path = DependencyService.Get<IFileHelper>().GetLocalFilePath("database.db");
            dbconn = new SQLiteConnection(path);

            dbconn.CreateTable<Student>();
        }

        override protected void OnAppearing()
        {
            list.ItemsSource = dbconn.Table<Student>().ToList();
        }

        private void buttonAddStudent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddPage());
        }

        private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var student = e.SelectedItem as Student;
            Navigation.PushModalAsync(new DetailsPage(student));
        }
    }
}
