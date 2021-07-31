using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class ChamadoRepository : IChamadoRepository
    {
        private readonly AppDbContext _context;
        public ChamadoRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Chamado> Chamados => _context.Chamados;
        /*
        public IEnumerable<Chamado> ChamadosPorCategoria => throw new NotImplementedException();

        public IEnumerable<Chamado> ChamadosPorCliente => throw new NotImplementedException();

        public IEnumerable<Chamado> ChamadosPorFuncionario => throw new NotImplementedException();

        public IEnumerable<Chamado> ChamadosPorPrioridade => throw new NotImplementedException();

        public IEnumerable<Chamado> ChamadoPorSituacao => throw new NotImplementedException();

        public IEnumerable<Chamado> ChamadoPorDescricao(string chamadoDescricao)
        {
            return _context.Chamados.Where(cd => cd.Descricao == chamadoDescricao);
        }

        public IEnumerable<Chamado> ChamadosPorId(int chamadoId)
        {
            throw new NotImplementedException();
        }
        */
    }
}
