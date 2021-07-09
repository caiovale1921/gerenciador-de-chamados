using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiTech
{
    public class Categoria
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }
        public List<Chamado> Chamados { get; set; }

    }
}
