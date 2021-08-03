    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories.Interfaces
{
    public interface ISituacaoRepository
    {
        public IEnumerable<Situacao> Situacaos { get; set; }
        public IEnumerable<Situacao> SituacoesPorId(int situacaoId);
    }
}
