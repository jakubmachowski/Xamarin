using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App4
{
    public class Student
    {
        [PrimaryKey]
        public string NumerIndeksu { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}
