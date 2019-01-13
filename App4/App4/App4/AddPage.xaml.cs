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
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddPage : ContentPage
	{
        private SQLiteConnection dbconn;

        public AddPage ()
		{
			InitializeComponent ();

            var path = DependencyService.Get<IFileHelper>().GetLocalFilePath("database.db");
            dbconn = new SQLiteConnection(path);
        }

        private void button_add_student(object sender, EventArgs e)
        {
            dbconn.Insert(new Student
            {
                NumerIndeksu = numerIndeksu.Text,
                Imie = imie.Text,
                Nazwisko = nazwisko.Text
            });

            Navigation.PopModalAsync();
        }
    }
}