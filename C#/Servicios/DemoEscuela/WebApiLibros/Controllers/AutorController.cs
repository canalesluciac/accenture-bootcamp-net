using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLibros.Contexto;
using WebApiLibros.Entidades;


namespace WebApiLibros.Controllers
{
    [Route("api/[controller]")]     // endpoint: api/autor
    [ApiController]                 // Indica controlador de web api
    public class AutorController : ControllerBase       // Indica controlador de web api
    {
        // contexto definido localmente y de solo lectura
        private readonly ApplicationDbContext context;
        

        // Inyecta instancia de App..DBContext en controlador, para usar instancia de EF
        public AutorController(ApplicationDbContext context) 
        {
            this.context = context;
        }

        #region Métodos

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()
        {
            return context.Autores.ToList(); 
        }

        [HttpGet("{id}", Name = "ObtenerAutor")]
        public ActionResult<Autor> Get(int id) 
        {
            var resultado = context.Autores.FirstOrDefault( x=> x.Id == id);
            if (resultado == null)
            {
                return NotFound();
            }
            return resultado;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            context.Autores.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("Obtener autor", new { id = autor.Id }, autor);
           
            /*if (!ModelState.IsValid)                // Controla que el modelo sea válido
            { return BadRequest(ModelState); }*/
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autor value) // Autor comes from body (http)
        {
            if (id!= value.Id) { BadRequest(); }        // comprueba que el ID de la URL y del cuerpo del autor sean iguales
            context.Entry(value).State = EntityState.Modified;
            context.SaveChanges();
            return Ok(); // o NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Autor> Delete(int id) 
        {
            var resultado = context.Autores.FirstOrDefault( x=> x.Id == id); // busca al autor en la base de datos
            if (resultado == null)
            {
                return NotFound(); //404
            }
            context.Autores.Remove(resultado);
            context.SaveChanges();
            return resultado;
        }
        #endregion
    }
}
