using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> Clientes { get; }
    }
}
