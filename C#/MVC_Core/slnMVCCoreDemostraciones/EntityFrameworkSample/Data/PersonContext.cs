using EntityFrameworkSample.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkExample.Data
{

    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Opcional para inicializar datos en la Base de Datos --> Tabla Person con 2 personas
            modelBuilder.Entity<Person>().HasData(
               new Person
               {
                   PersonId = 1,
                   FirstName = "Tara",
                   LastName = "Brewer",
                   City = "Ocala",
                   Address = "317 Long Street"
               },
               new Person
               {
                   PersonId = 2,
                   FirstName = "Andrew",
                   LastName = "Tippett",
                   City = "Anaheim",
                   Address = "3163 Nickel Road"
               });
        }
    }
}
