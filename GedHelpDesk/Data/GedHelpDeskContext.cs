using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GedHelpDesk.Models
{
    public class GedHelpDeskContext : DbContext
    {
        public GedHelpDeskContext (DbContextOptions<GedHelpDeskContext> options)
            : base(options)
        {
        }

        public DbSet<GedHelpDesk.Models.Usuario> Usuario { get; set; }
    }
}
