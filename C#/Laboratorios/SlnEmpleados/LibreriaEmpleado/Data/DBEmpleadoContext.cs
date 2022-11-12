using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaEmpleado.Models;
using System.Data.Entity;
namespace LibreriaEmpleado.Data
{
    public class DBEmpleadoContext:DbContext
    {
        //constructor abstracto derivado
        public DBEmpleadoContext(): base("keyDBEmpleado") { }

        //propiedad DBSet por cada modelo
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}
