using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiDemo.Controllers
{
    // Prueba para conectarse al servicio: /api/test
    [Route("api/[controller]")]  // La ruta para entrar al servicio usa api/nombre del controlador
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/Test/ por convención ejecuta api/Test/Get    api/<TestController>
        [HttpGet]
        public IEnumerable<string> Get() // Agregar Using generics
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestController>/5  --> GET api/Test/5
        [HttpGet("{id}")] // Decoracion --> recibe Id
        public string Get(int id) //retorna string, recibe id x parametro
        {
            return "value" + id.ToString();
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
