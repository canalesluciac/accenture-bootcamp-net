 using WebPasajero.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebPasajero.Data
{
    public class PasajeroContext : DbContext
    {
        public PasajeroContext(DbContextOptions<PasajeroContext> options)
            : base(options)
        { }

        public DbSet<Pasajero> Pasajeros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Opcional para inicializar datos en la Base de Datos --> Tabla Person con 2 personas
            _ = modelBuilder.Entity<Pasajero>().HasData(
               new Pasajero
               {
                   Id = 1,
                   Nombre = "Ana",
                   Apellido = "Lopez",
                   Ciudad = "Mar del Plata",
                   FechaNacimiento = DateTime.MinValue


               },
               new Pasajero
               {
                   Id = 2,
                   Nombre = "Pedro",
                   Apellido = "Lopez",
                   Ciudad = "Mar del Plata",
                   FechaNacimiento = DateTime.Now
               });
        }
    }
}
