using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class PeliculaoSerie
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }

        public int Personajeid { get; set; }
        public Personaje Personajes { get; set; }

        public int Generoid { get; set; }
        public Genero Genero { get; set; }
    }
}
