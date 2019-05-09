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
    [Route("api/Materias")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ContextDb _context;

        public CursoController(ContextDb context)
        {
            _context = context;
        }

        // GET: api/Curso
        [HttpGet]
        public IEnumerable<Cursos> GetCurso()
        {
            return _context.Cursos;
        }

        // GET: api/Curso/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var curso = await _context.Cursos.FindAsync(id);

            if (curso == null)
            {
                return NotFound();
            }

            return Ok(curso);
        }

        // PUT: api/Curso/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurso([FromRoute] int id, [FromBody] Cursos curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != curso.Id)
            {
                return BadRequest();
            }

            _context.Entry(curso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursoExists(id))
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

        // POST: api/Curso
        [HttpPost]
        public async Task<IActionResult> PostCurso([FromBody] Cursos curso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurso", new { id = curso.Id }, curso);
        }

        // DELETE: api/Curso/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurso([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null)
            {
                return NotFound();
            }

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return Ok(curso);
        }

        private bool CursoExists(int id)
        {
            return _context.Cursos.Any(e => e.Id == id);
        }
    }
}