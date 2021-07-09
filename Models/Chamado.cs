using System;
using System.ComponentModel.DataAnnotations;

namespace TiTech
{
    public class Chamado
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public int SituacaoId { get; set; }
        public virtual Situacao Situacao { get; set; }
        public int PrioridadeId { get; set; }
        public virtual Prioridade Prioridade { get; set; }
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        public DateTime Vencimento { get; set; }
        [StringLength(255)]
        public string Descricao { get; set; }

    }
}
