using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class SituacaoRepository : ISituacaoRepository
    {
        public readonly AppDbContext _context;
        public SituacaoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Situacao> Situacaos { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<Situacao> SituacoesPorId(int situacaoId)
        {
            throw new NotImplementedException();
        }
    }
}
