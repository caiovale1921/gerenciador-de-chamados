using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiTech
{
    public class Cliente
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        public List<Chamado> Chamados { get; set; }
    }
}
