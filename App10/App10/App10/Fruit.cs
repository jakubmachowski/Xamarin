using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App10
{
    public class Fruit
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSweet { get; set; }
    }
}
