using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Models
{
    public class RecipieItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Steps { get; set; }
        public string Steps2 { get; set; }
        public string Steps3 { get; set; }
        public string Steps4 { get; set; }
        public string Steps5 { get; set; }
        public string Ingridients { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
     
    }
}
