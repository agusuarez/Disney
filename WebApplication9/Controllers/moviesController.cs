using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Context;

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class moviesController : Controller
    {
        
        private readonly AplicationDbContext _context;

        public moviesController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<moviesController>> Getmovies()
        {
            try
            {
                var listapeliculas = await _context.PeliculaoSerie.ToListAsync();
                return Ok(listapeliculas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<moviesController>> Getmovies(int id)
        {
            try
            {
                var pelicula = await _context.PeliculaoSerie.FindAsync(id);
                return Ok(pelicula);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var pelicula = await _context.PeliculaoSerie.FindAsync(id);
                if (pelicula == null)
                {
                    return NotFound();
                }
                _context.PeliculaoSerie.Remove(pelicula);
                await _context.SaveChangesAsync();
                return Ok(new { messagge = "Pelicula o Serie eliminada con éxito." });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
