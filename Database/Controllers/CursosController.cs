using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Models;

namespace Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        private readonly ContextDb _context;

        public CursosController(ContextDb context)
        {
            _context = context;
        }

        // GET: api/Cursos
        [HttpGet]
        public IEnumerable<CursosAlumnos> GetCursosAlumnos()
        {
            return _context.CursosAlumnos;
        }

        // GET: api/Cursos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCursosAlumnos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cursosAlumnos = await _context.CursosAlumnos.FindAsync(id);

            if (cursosAlumnos == null)
            {
                return NotFound();
            }

            return Ok(cursosAlumnos);
        }

        // PUT: api/Cursos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursosAlumnos([FromRoute] int id, [FromBody] CursosAlumnos cursosAlumnos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cursosAlumnos.AlumnoId)
            {
                return BadRequest();
            }

            _context.Entry(cursosAlumnos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursosAlumnosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cursos
        [HttpPost]
        public async Task<IActionResult> PostCursosAlumnos([FromBody] CursosAlumnos cursosAlumnos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CursosAlumnos.Add(cursosAlumnos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CursosAlumnosExists(cursosAlumnos.AlumnoId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCursosAlumnos", new { id = cursosAlumnos.AlumnoId }, cursosAlumnos);
        }

        // DELETE: api/Cursos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursosAlumnos([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cursosAlumnos = await _context.CursosAlumnos.FindAsync(id);
            if (cursosAlumnos == null)
            {
                return NotFound();
            }

            _context.CursosAlumnos.Remove(cursosAlumnos);
            await _context.SaveChangesAsync();

            return Ok(cursosAlumnos);
        }

        private bool CursosAlumnosExists(int id)
        {
            return _context.CursosAlumnos.Any(e => e.AlumnoId == id);
        }
    }
}