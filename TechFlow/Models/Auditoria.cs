using System;

namespace TechFlow.Models
{
    public class Auditoria
    {
        public int Id { get; set; }
        public DateTime DataAcao { get; set; }
        public string Usuario { get; set; }
        public string Acao { get; set; }
        public string Descricao { get; set; }
    }
}
