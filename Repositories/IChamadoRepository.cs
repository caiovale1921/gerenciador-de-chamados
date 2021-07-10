using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories
{
    public interface IChamadoRepository
    {
        public IEnumerable<Chamado> Chamados { get; }
    }
}
