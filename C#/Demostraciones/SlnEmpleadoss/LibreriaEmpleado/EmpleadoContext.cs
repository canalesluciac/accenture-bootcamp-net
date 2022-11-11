using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibreriaEmpleado.Derivadas
{
    public partial class EmpleadoContext : DbContext
    {
        public EmpleadoContext()
            : base("name=keyDBEmpleados")
        {
        }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Completar si hay tiempo
            modelBuilder.Entity<Cliente>()
                ;
            modelBuilder.Entity<Empleado>();
            modelBuilder.Entity<Departamento>();
        }
    }
}
