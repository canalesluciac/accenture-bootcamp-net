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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            /*modelBuilder.Entity<Aula>()
                .ToTable("Aula")
                .HasKey(a => a.Id)
                .Property(a => a.Capacidad).IsRequired();
            modelBuilder.Entity<Aula>().Property(a =>a.Codigo)
                .IsRequired()
                .HasColumnType("char")
                .HasMaxLength(50);  */
            //modelBuilder.Entity<Aula>().HasForeignKey(a => a.Materia);

            modelBuilder.Entity<Materia>().ToTable("Materia");
            //modelBuilder.Entity<Materia>().HasKey(a => a.Id);
            modelBuilder.Entity<Materia>().Property(a => a.Nombre).IsRequired();
            modelBuilder.Entity<Materia>().Property(a => a.Nombre).HasColumnType("varchar");
            modelBuilder.Entity<Materia>().Property(a => a.Nombre).HasMaxLength(50);
            modelBuilder.Entity<Materia>().Property(a => a.Programa).IsRequired();
            modelBuilder.Entity<Materia>().Property(a => a.Programa).HasColumnType("varchar");
            modelBuilder.Entity<Materia>().Property(a => a.Programa).HasMaxLength(50);


        }
    }
}
