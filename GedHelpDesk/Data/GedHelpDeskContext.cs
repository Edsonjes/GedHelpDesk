using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GedHelpDesk.Models
{
    public class GedHelpDeskContext : DbContext
    {
        public GedHelpDeskContext(DbContextOptions<GedHelpDeskContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Chamados> Chamados { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
   
}
