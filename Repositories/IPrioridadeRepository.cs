using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories
{
    public interface IPrioridadeRepository
    {
        public IEnumerable<Prioridade> Prioridades { get; set; }
    }
}
