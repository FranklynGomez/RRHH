using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class RRHHContext : DbContext
    {
        public RRHHContext() : base("RRHHEntities") { }
        public DbSet<FORM_RRHH> FORM_RRHHS { get; set; }
        public DbSet<EVALUACION_RRHH> EVALUACION_RRHHS { get; set; }
    }
}
