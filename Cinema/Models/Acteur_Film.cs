using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class Acteur_Film
    {
        public int? FilmId { get; set; }
        public Film Film { get; set; }
        public int? ActeurId { get; set; }
        public Acteur Acteur { get; set; }
    }
}
