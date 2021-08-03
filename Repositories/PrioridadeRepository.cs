using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class PrioridadeRepository : IPrioridadeRepository
    {
        public readonly AppDbContext _context;
        public PrioridadeRepository(AppDbContext contexo)
        {
            _context = contexo;
        }
        public IEnumerable<Prioridade> Prioridades { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Prioridade> PrioridadesPorId(int prioridadeId)
        {
            throw new NotImplementedException();
        }
    }
}
