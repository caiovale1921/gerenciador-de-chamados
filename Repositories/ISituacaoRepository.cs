    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories
{
    public interface ISituacaoRepository
    {
        public IEnumerable<Situacao> Situacaos { get; set; }
    }
}
