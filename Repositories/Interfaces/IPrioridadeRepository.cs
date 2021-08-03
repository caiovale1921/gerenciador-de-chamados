using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories.Interfaces
{
    public interface IPrioridadeRepository
    {
        public IEnumerable<Prioridade> Prioridades { get; set; }
        public IEnumerable<Prioridade> PrioridadesPorId(int prioridadeId);
    }
}
