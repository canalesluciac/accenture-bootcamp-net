using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; //
using System.Collections.Generic; // !! para crear List<> o IEnumerable
using System.Linq;              // !! para el ToList()
using WebApiEscuela.Data; // !! proyecto.data
using WebApiEscuela.Models; // !! proyecto.models
namespace WebApiEscuela.Controllers
{

    // GET /api/Profesor --> Indica servicio. El startup genera objeto DbContext y lo pasa al
    // constructor del controller. VER MINUTO 43 FALTA EXPLICACION
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        public DBEscuelaAPIContext Context { get; set; }     // Propiedad context

        
        public ProfesorController(DBEscuelaAPIContext context) // Constructor
        {
            this.Context = context;
        }

        [HttpGet] // LISTA profesores
        public List<Profesor>Get()
        {
            // EF --> Luego se encapsula en clase para que no quede en servicio
            List<Profesor> profesores = Context.Profesores.ToList();
            return profesores;
        }

        // Decoracion
        [HttpGet("{id}")] // TRAE UN profesor
        public Profesor Get(int id)
        {
            Profesor profesor = Context.Profesores.Find(id);
            return profesor;
        }

        [HttpPost] // INSERTA 
        public ActionResult Post(Profesor profesor)
        {
            // EF -- agregar en memoria
            Context.Profesores.Add(profesor); // se agrega al profesor pasado por parámetro

            // EF -- guardar en la DB
            Context.SaveChanges();

            return Ok();    // OK == Código 200
        }

        [HttpPut("{id}")] // MODIFICA  --> FromBody indica que el cliente envía profesor modificado desde cuerpo del http
        public ActionResult Put (int id, [FromBody] Profesor profesor) //objeto a localizar en la base, objeto modificado
        {
            if (id != profesor.Id) // si no coincide el id con el del objeto modificado
            {
                return BadRequest(); // código 400
            }

            // EF -- modificar en la DB
            Context.Entry(profesor).State = EntityState.Modified; // marca "profesor" para modificar
            Context.SaveChanges();

            return NoContent(); // no content = 204
        }

        [HttpDelete("{id}")] // ELIMINA + envía copia de DB al cliente
        public ActionResult<Profesor>Delete(int id)
        {
            //EF -- buscar profesor a eliminar (con find o fist of default
            Profesor profesor = Context.Profesores.Find(id);

            if (profesor == null)
            {
                return NotFound(); // not found = 404
            }

            // EF -- borra
            Context.Profesores.Remove(profesor); // si lo encuentra, lo borra
            Context.SaveChanges();

            return profesor;
        }
    }
}
