using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniderFilms.Models
{
    public class Papel
    {
        public int Cast_Order { get; set; }
        public string Character_Name { get; set; }
        public int Gender_Id { get; set; }
        public int Movie_Id { get; set; }
        public int Person_Id { get; set; }
    }
}
