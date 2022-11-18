using Microsoft.EntityFrameworkCore;
using WSAutoCanales.Models;

namespace WSAutoCanales.Data
{
    public class DBAutoAPIContext : DbContext
    {
        public DBAutoAPIContext(DbContextOptions<DBAutoAPIContext> options) : base(options) { }

        //DbSet
        public DbSet<Auto> Autos { get; set; }
    }
}
