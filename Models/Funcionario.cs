using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiTech
{
    public class Funcionario
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Cargo { get; set; }
        public List<Chamado> Chamados { get; set; }
    }
}
