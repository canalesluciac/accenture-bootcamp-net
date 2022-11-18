using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore; //
using System.Collections.Generic; // !! para crear List<> o IEnumerable
using System.Linq;              // !! para el ToList()
using WSAutoCanales.Data; // !! proyecto.data
using WSAutoCanales.Models; // !! proyecto.models

namespace WSAutoCanales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        public DBAutoAPIContext _context { get; set; }
        public AutoController(DBAutoAPIContext context)
        { 
            this._context = context; 
        }

        // GET api/auto/
        [HttpGet]
        public List<Auto> Get()
        {
            List<Auto> list = _context.Autos.ToList();
            return list;
        }

        // GET api/auto/modelo
        [HttpGet("{Modelo}")]
        public Auto Get(string Modelo)
        {
            var auto = (from a in _context.Autos
                        where a.Modelo== Modelo
                        select a).SingleOrDefault();
            return auto;
        }

        [HttpPost]
        public ActionResult Post (Auto auto)
        {
            _context.Autos.Add(auto);
            _context.SaveChanges();
            return Ok();
        }

        // SEGUNDA PARTE

        // GET api/auto/id
        [HttpGet("{id}")]
        public Auto Get(int id)
        {
            var auto = (from a in _context.Autos
                        where a.AutoId== id
                        select a).SingleOrDefault();
            return auto;
        }

        [HttpPut("{id}")] // Modifica un auto
        public ActionResult Put(int id, [FromBody] Auto auto) 
        {
            if (id != auto.AutoId)
            { return BadRequest();
            }
            _context.Entry(auto).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")] // Elimina un auto
        public ActionResult<Auto> Delete(int id)
        {
            Auto auto = _context.Autos.Find(id);
            if (auto == null)
            { return NoContent();}
            _context.Autos.Remove(auto);    
            _context.SaveChanges();
            return auto;
        }

        [HttpGet("{Marca}/{Modelo}")] // Trae autos por marca y modelo
        public List<Auto> Get(string Marca, string Modelo)
        {
            dynamic auto = (from a in _context.Autos
                        where a.Marca == Marca &&
                        a.Modelo == Modelo
                        select a);
            return auto;
        }

        /*[HttpGet("{color}")]      // ERROR - SUPERPOSICION CON GET QUE TRAE POR MODELO
        public dynamic Get(string color)
        {
            dynamic autos = (from a in _context.Autos
                            where a.Color == color
                            select new { a.AutoId, a.Marca, a.Precio, a.Color});
            return autos;
        }*/
    }
}
