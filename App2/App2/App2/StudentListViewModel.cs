using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App2
{
    class StudentListViewModel : INotifyPropertyChanged
    {
        public StudentListViewModel()
        {
            Student = new List<Student>();
            Student.Add(new Student() { Imie = "Jan", Nazwisko = "Kowalski", NumerIndeksu = "001" });
            Student.Add(new Student() { Imie = "Jakub", Nazwisko = "Machowski", NumerIndeksu = "002" });
        }


        private Student selectedStudent;
        public Student SelectedStudent
        {
            get
            {
                return selectedStudent;
            }

            set
            {
                if (selectedStudent != value)
                {
                    selectedStudent = value;
                    OnPropertyChanged();
                }
            }
        }

        public List<Student> Student { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
