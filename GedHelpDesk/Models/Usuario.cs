using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace GedHelpDesk.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public ICollection<Chamados> ChamadosUser { get; set; } = new List<Chamados>();

        public Usuario()
        {

        }



        public Usuario(int id, string nome, string email, int senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;

        }

        public void AddChamado (Chamados cham)
        {
            ChamadosUser.Add(cham);
        }

        public void RemoverChamado (Chamados cham)
        {
            ChamadosUser.Remove(cham);
        }

      
    }



}
