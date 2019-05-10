namespace Database.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Data;

    [Route("api/Mensaje")]
    [ApiController]
    public class MensajesController : Controller
    {
        private readonly IRepositorioMensajes repositorio;

        public MensajesController(IRepositorioMensajes repositorio)
        {
            this.repositorio = repositorio;
        }

        // Obtener listado de mensajes
        [HttpGet]
        public JsonResult GetMensajes()
        {
            return new JsonResult(this.repositorio.GetMensajes());
        }

        // Obtener Mensaje por id
        [HttpGet("{id}")]
        public IActionResult GetMensajes(int? id)
        {
            if (id == null)
            {
                return BadRequest(ModelState);
            }

            var mensaje = this.repositorio.GetMensaje(id.Value);

            if (mensaje == null)
            {
                return NotFound();
            }

            return Ok(mensaje);
        }

        // Crear mensaje
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMensaje([FromRoute] int id, [FromBody] Mensajes mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mensaje.Id)
            {
                return BadRequest();
            }

            this.repositorio.AddMensaje(mensaje);

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

        // POST: api/Mensaje
        [HttpPost]
        public async Task<IActionResult> PostMensaje([FromBody] Mensajes mensaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            this.repositorio.AddMensaje(mensaje);
            await this.repositorio.SaveAllAsync();

            return CreatedAtAction("GetAlumno", new { id = mensaje.Id }, mensaje);
        }

        // DELETE: api/Alumno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMensaje([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mensaje = this.repositorio.GetMensaje(id);
            if (mensaje == null)
            {
                return NotFound();
            }

            this.repositorio.RemoveMensaje(mensaje);
            await this.repositorio.SaveAllAsync();

            return Ok(mensaje);
        }

        private bool AlumnoExists(int id)
        {
            //return this.repositorio.GetMensaje(Any.id);
            return false;
        }
    }
}