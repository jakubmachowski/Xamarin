using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App2
{
    class Student : INotifyPropertyChanged
    {
        private string imie;
        public string Imie
        {
            get
            {
                return imie;
            }

            set
            {
                if (imie != value)
                {
                    imie = value;
                    OnPropertyChanged();
                }
            }
        }

        private string nazwisko;
        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }

            set
            {
                if (nazwisko != value)
                {
                    nazwisko = value;
                    OnPropertyChanged();
                }
            }
        }

        private string numerIndeksu;
        public string NumerIndeksu
        {
            get
            {
                return numerIndeksu;
            }

            set
            {
                if (numerIndeksu != value)
                {
                    numerIndeksu = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return NumerIndeksu;
        }
    }
}
