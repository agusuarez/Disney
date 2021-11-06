using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class Genero
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public ICollection<PeliculaoSerie> PeliculaoSerie { get; set; }
    }
}
