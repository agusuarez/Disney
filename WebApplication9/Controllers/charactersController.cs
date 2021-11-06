using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication9.Context;
using WebApplication9.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class charactersController : ControllerBase
    {

        private readonly AplicationDbContext _context;

        public charactersController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<charactersController>> GetCharacters()
        {
            try
            {
                var listapersonajes = await _context.Personajes.ToListAsync();
                return Ok(listapersonajes);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<charactersController>> GetCharacters(int id)
        {
            try
            {
                var personaje = await _context.Personajes.FindAsync(id);
                return Ok(personaje);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody]Personaje personaje)
        {
            try
            {
                _context.Personajes.Add(personaje);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El personaje se registro con exito." });
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
                var personaje = await _context.Personajes.FindAsync(id);
                if (personaje == null)
                {
                    return NotFound();
                }
                _context.Personajes.Remove(personaje);
                await _context.SaveChangesAsync();
                return Ok(new { messagge = "Personaje eliminado con exito." });
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
