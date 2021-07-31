using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public readonly AppDbContext _context;
        public FuncionarioRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Funcionario> Funcionarios => throw new NotImplementedException();

        public IEnumerable<Funcionario> FuncionariosPorId(int funcionarioId)
        {
            throw new NotImplementedException();
        }
    }
}
