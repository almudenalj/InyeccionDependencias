using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InyecciónDependenciasHipica.Models
{
    public class CaballosContext : DbContext
    {
        public CaballosContext() : base("name=cadenacaballos") { }
        public DbSet<Caballo> Caballos { get; set; }
    }
}