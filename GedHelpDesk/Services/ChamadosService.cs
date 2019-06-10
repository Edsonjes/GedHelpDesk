using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GedHelpDesk.Models;

namespace GedHelpDesk.Services
{
    public class ChamadosService
    {
        private readonly GedHelpDeskContext _context;

        public ChamadosService(GedHelpDeskContext context)
        {
            _context = context;
        }

        public List<Chamados> FidnAll()
        {
            return _context.Chamados.ToList();
        }
    }
}
