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
    [Route("api/Alumno")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly ContextDb _context;

        public AlumnoController(ContextDb context)
        {
            _context = context;
        }

        // GET: api/Alumno
        [HttpGet]
        public JsonResult GetAlumnos()
        {
			return new JsonResult(_context.Alumnos);
        }

        // GET: api/Alumno/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlumno([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumno = await _context.Alumnos.FindAsync(id);

            if (alumno == null)
            {
                return NotFound();
            }

            return Ok(alumno);
        }

        // PUT: api/Alumno/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumno([FromRoute] string id, [FromBody] Alumnos alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != alumno.Id)
            {
                return BadRequest();
            }

            _context.Entry(alumno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoExists(id))
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

        // POST: api/Alumno
        [HttpPost]
        public async Task<IActionResult> PostAlumno([FromBody] Alumnos alumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Alumnos.Add(alumno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumno", new { id = alumno.Id }, alumno);
        }

        // DELETE: api/Alumno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumno([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno == null)
            {
                return NotFound();
            }

            _context.Alumnos.Remove(alumno);
            await _context.SaveChangesAsync();

            return Ok(alumno);
        }

        private bool AlumnoExists(string id)
        {
            return _context.Alumnos.Any(e => e.Id == id);
        }
    }
}