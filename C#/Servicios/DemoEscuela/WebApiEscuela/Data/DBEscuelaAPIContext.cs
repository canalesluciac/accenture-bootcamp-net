using Microsoft.EntityFrameworkCore;
using WebApiEscuela.Models;

namespace WebApiEscuela.Data
{
    public class DBEscuelaAPIContext:DbContext
    {
        //CORE declarar siempre constructor de esta forma
        public DBEscuelaAPIContext(DbContextOptions<DBEscuelaAPIContext> options): base(options) { }

        //DBSET
        public DbSet<Alumno> Alumnos { get; set; } // plural y 1ra en mayuscula!
        public DbSet<Especialidad> Especialidades { get;set; }
        public DbSet<Profesor> Profesores { get; set; }
        
    }
}
