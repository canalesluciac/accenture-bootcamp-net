using System;
using System.Linq;

using System.Data.Entity;
using LibreriaEmpleado.Models;

namespace WindowsEmpleados.Data
{
    public class DBEmpleados : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'DBEmpleados' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'WindowsEmpleados.Data.DBEmpleados' de la instancia LocalDb. 
        // destino una base de datos diferente, modifique la cadena de conexión 'DBEmpleados'  en el archivo de configuración de la aplicación.
        public DBEmpleados() : base("keyDBEmpleados") { }

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>()
                .HasMany(d => d.Empleados);

            modelBuilder.Entity<Empleado>()
                .HasRequired(e => e.Departamento)
                .WithMany(d => d.Empleados)
                .HasForeignKey(e => e.Departamento);

        }
    }
}