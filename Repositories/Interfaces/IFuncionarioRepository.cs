using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    {
        public IEnumerable<Funcionario> Funcionarios { get; }
        public IEnumerable<Funcionario> FuncionariosPorId(int funcionarioId);
    }
}
