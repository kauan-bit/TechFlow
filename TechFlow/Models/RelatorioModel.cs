using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechFlow.Models
{
    public class RelatorioModel
    {
        public int IdChamado { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Prioridade { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        public string Usuario { get; set; }
        public string Tecnico { get; set; }
        public string Setor { get; set; }
        public string Categoria { get; set; }
    }
}

