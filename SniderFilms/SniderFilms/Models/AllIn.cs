using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SniderFilms.Models
{
    public class AllIn
    {
        public List<Actor> Actor { get; set; }
        public List<Company> Company { get; set; }
        public List<Country> Country { get; set; }
        public List<Genre> Genre { get; set; }
        public List<Language> Language { get; set; }
        public Movie Movie { get; set; }

        public int MovieId { get; set; }
        public List<Papel> Papel { get; set; }
    }
}
