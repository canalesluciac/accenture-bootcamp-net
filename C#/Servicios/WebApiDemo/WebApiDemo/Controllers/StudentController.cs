using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using WebApiDemo.Models;
namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students()
        {
            List<Student> studentsLocal = new List<Student>() // Crea lista estudiantes
            {
                new Student() {Id=1, LastName="Pint", Name="Gustavo"}, //Agrega 3 estudiantes
                new Student() {Id=2, LastName="Pint", Name="Baltasar"},
                new Student() {Id=3, LastName="Pint", Name="Daniela"}
            };

            return studentsLocal;
        }

        // GET: /api/student/   --> Buena práctica: se pone qué se trae el método
        [HttpGet] // Metodo -> Retorna todos los estudiantes
        public IEnumerable<Student> Get()
        {
            return students();
        }

        //GET; /api/student/id    --> Ej api/student/3
        [HttpGet("{id}")]
        public Student Get(int id) // Metodo -> Retorna 1 estudiante (por json)
        {
            Student student = students().Find(x => x.Id == id); // Busca en lista al estudiante que coincide con el id
            return student; 
        }
    }
}
