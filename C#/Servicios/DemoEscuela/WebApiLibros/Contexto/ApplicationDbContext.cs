using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebApiLibros.Entidades;

namespace WebApiLibros.Contexto
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Autor> Autores { get; set; } // mapeo a tabla de DB
    }
}
