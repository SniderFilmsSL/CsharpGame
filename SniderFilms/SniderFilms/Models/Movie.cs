using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniderFilms.Models
{
    public class Movie
    {
        public int Budget { get; set; }
        public string Homepage { get; set; }
        public int Movie_Id { get; set; }
        public string Movie_Status { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string Release_Date { get; set; }
        public int Revenue { get; set; }
        public int Runtime { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public double Vote_Average { get; set; }
        public int Vote_Count { get; set; }
    }
}
