using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GedHelpDesk.Models
{
    public class Chamados
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        DateTime Hora { get; set; }
        DateTime Data { get; set; }
    }
}
