using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiTech.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        public IEnumerable<Cliente> Clientes { get; }
        public IEnumerable<Cliente> ClientesPorId(int clienteId);
    }
}
