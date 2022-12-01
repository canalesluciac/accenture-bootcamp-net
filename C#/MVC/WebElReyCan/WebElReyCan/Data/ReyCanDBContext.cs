using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class ReyCanDBContext:DbContext
    {
        public ReyCanDBContext() : base("keyCanDB") { }
        public DbSet<Turno> Turnos { get; set; }
    }
}