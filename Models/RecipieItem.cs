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
        public string Ingridients { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string CreatedByName { get; set; }

    }
}
