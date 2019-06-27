using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GedHelpDesk.Models;


namespace GedHelpDesk.Services
{
    public class LoginService 
    {
        private readonly GedHelpDeskContext _context;
        
        public LoginService (GedHelpDeskContext context)
        {
            _context = context;
        }
    }
}
