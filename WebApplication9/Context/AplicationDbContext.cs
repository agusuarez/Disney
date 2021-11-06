using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Models;

namespace WebApplication9.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<PeliculaoSerie> PeliculaoSerie { get; set; }
        public DbSet<Genero> Generos { get; set;}

    }
}
