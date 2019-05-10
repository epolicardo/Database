﻿namespace Database.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Data;

    [Route("api/Alumno")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly IRepositorioAlumnos repositorio;

        public AlumnoController(IRepositorioAlumnos repositorio)
        {
            this.repositorio = repositorio;
        }

        // GET: api/Alumno
        [HttpGet]
        public JsonResult GetAlumnos()
        {
            return new JsonResult(this.repositorio.GetAlumnos());
        }

        // GET: api/Alumno/5
        [HttpGet("{id}")]
        public IActionResult GetAlumno([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var alumno = this.repositorio.GetAlumno(id);

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

            this.repositorio.AddAlumno(alumno);

            try
            {
                await this.repositorio.SaveAllAsync();
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

            this.repositorio.AddAlumno(alumno);
            await this.repositorio.SaveAllAsync();

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

            var alumno = this.repositorio.GetAlumno(id);
            if (alumno == null)
            {
                return NotFound();
            }

            this.repositorio.RemoveAlumno(alumno);
            await this.repositorio.SaveAllAsync();

            return Ok(alumno);
        }

        private bool AlumnoExists(string id)
        {
            //TODO Cambiar este metodo.
            return false;
            //return this.repositorio.GetAlumno.Any(e => e.Id == id);
        }
    }
}