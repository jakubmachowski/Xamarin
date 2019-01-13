using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            float h = float.Parse(eHeight.Text);
            float w = float.Parse(eWeight.Text);

            result.Text = "Twoje BMI: "+(w / ((h / 100) * (h / 100))).ToString("F2");
        }

        private void EHeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(eHeight.Text) && !string.IsNullOrEmpty(eWeight.Text))
            {
                bCalc.IsEnabled = true;
            } else
            {
                bCalc.IsEnabled = false;
            }
        }

        private void EWeight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(eWeight.Text) && !string.IsNullOrEmpty(eWeight.Text))
            {
                bCalc.IsEnabled = true;
            }
            else
            {
                bCalc.IsEnabled = false;
            }
        }
    }
}
