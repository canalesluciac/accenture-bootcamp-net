using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore; //
using System.Collections.Generic; // !! para crear List<> o IEnumerable
using System.Linq;              // !! para el ToList()
using WebApiEscuela.Data; // !! proyecto.data
using WebApiEscuela.Models; // !! proyecto.models
namespace WebApiEscuela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        public DBEscuelaAPIContext Context { get; set; }     // Propiedad context

        public AlumnoController(DBEscuelaAPIContext context)  // Constructor
        {
            this.Context = context;
        }

        #region Métodos
        [HttpGet]
        public List<Alumno>Get()
        {
            List<Alumno> alumnos = Context.Alumnos.ToList();
            return alumnos;
        }

        [HttpGet("{id}")]
        public Alumno Get(int id)
        {
            Alumno alumno = Context.Alumnos.Find(id);
            return alumno;
        }

        [HttpPost]
        public ActionResult Post(Alumno alumno)
        {
            Context.Alumnos.Add(alumno);
            Context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return BadRequest();
            }

            Context.Entry(alumno).State= EntityState.Modified;
            Context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int id)
        {
            Alumno alumno = Context.Alumnos.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }

            Context.Alumnos.Remove(alumno);
            Context.SaveChanges();

            return alumno;
        }
        #endregion
    }
}
