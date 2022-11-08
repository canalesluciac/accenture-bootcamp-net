using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsEFEscuela.Models;
using System.Data.Entity;
namespace WindowsEFEscuela.Data
{
    public class DBEscuelaContext:DbContext
    {
        public DBEscuelaContext() : base("keyDBEscuela") { }

        //por cada modelo una propiedad DBSET
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public DbSet<Materia> Materias { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}
