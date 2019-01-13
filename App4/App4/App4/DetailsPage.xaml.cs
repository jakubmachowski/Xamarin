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
    public partial class DetailsPage : ContentPage
    {

        private Student student;
        private SQLiteConnection dbconn;

        public DetailsPage(Student student)
        {
            this.student = student;
            InitializeComponent();

            var path = DependencyService.Get<IFileHelper>().GetLocalFilePath("database.db");
            dbconn = new SQLiteConnection(path);

            numerIndeksu.Text = student.NumerIndeksu;
            imie.Text = student.Imie;
            nazwisko.Text = student.Nazwisko;
        }

        private void buttonZapiszStudenta_Clicked(object sender, EventArgs e)
        {
            student.NumerIndeksu = numerIndeksu.Text;
            student.Imie = imie.Text;
            student.Nazwisko = nazwisko.Text;

            dbconn.Update(student);
            Navigation.PopModalAsync();
        }

        private void buttonUsunStudenta_Clicked(object sender, EventArgs e)
        {
            dbconn.Delete(student);
            Navigation.PopModalAsync();
        }

        private void buttonZamknij_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}