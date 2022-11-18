using Microsoft.EntityFrameworkCore;
using WebApiCanalesLucia.Models;

namespace WebApiCanalesLucia.Data
{
    public class DBHospitalAPI : DbContext
    {
        // Constructor
        public DBHospitalAPI(DbContextOptions<DBHospitalAPI> options) : base(options) { }

        //DBSET
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> Hospitales { get; set;}
    }
}
