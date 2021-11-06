using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class Personaje
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        public string Historia { get; set; }
        public ICollection<PeliculaoSerie> PeliculaoSerie { get; set; }
    }
}
