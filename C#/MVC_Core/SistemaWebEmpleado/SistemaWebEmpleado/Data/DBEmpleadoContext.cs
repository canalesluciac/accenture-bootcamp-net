using SistemaWebEmpleado.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace SistemaWebEmpleado.Data
{
    public class DBEmpleadoContext : DbContext
    {
        public DBEmpleadoContext(DbContextOptions<DBEmpleadoContext> options): base(options) { }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().HasData(
               new Empleado
               {
                   Id = 1,
                   Nombre = "Ana",
                   Apellido = "Lopez",
                   DNI = "40666165",
                   Legajo = "AA12345",
                   Titulo = "Programador"
               },
               new Empleado
               {
                   Id = 2,
                   Nombre = "Pedro",
                   Apellido = "Lopez",
                   DNI = "40666166",
                   Legajo = "AA12346",
                   Titulo = "Manager"
               });
        }

    }
}