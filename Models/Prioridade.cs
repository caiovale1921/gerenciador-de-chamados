using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiTech
{
    public class Prioridade
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        public List<Chamado> Chamados { get; set; }
    }
}
