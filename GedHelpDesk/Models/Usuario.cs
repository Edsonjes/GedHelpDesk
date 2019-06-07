using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GedHelpDesk.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public ICollection<Chamados> Chamados { get; set; } = new List<Chamados>();
    }
}
