using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace People.Models
{
    //Modelo Person
    [Table("people")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int idJDS { get; set; }

        [MaxLength(100), Unique]
        public string NameJDS { get; set; }
    }
}
