using Microsoft.EntityFrameworkCore;
using MVCPubs.Models;

namespace MVCPubs.Data
{
    public class PubsContext: DbContext
    {
        public PubsContext(DbContextOptions<PubsContext> options) : base(options) { }

        //public DbSet<Store> stores { get; set; }
    }
}
