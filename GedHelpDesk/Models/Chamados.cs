using GedHelpDesk.Models.Enums;
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
        public DateTime Hora { get; set; }
        public DateTime Data { get; set; }
        public ChamadoStatus Status { get; set; }
        public Usuario Usuario { get; set; }

        public Chamados()
        {
        }

        public Chamados(int id, string descricao, DateTime hora, DateTime data, ChamadoStatus status, Usuario usuario)
        {
            Id = id;
            Descricao = descricao;
            Hora = hora;
            Data = data;
            Status = status;
            Usuario = usuario;
        }

       
    }
}
