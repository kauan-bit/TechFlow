using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFlow.Models
{
    public class Tecnico
    {
        public int IdTecnico { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Especialidade { get; set; }
        public int? SetorId { get; set; }
    }
}
