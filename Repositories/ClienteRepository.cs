using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly AppDbContext _context;
        public ClienteRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Cliente> Clientes => throw new NotImplementedException();

        public IEnumerable<Cliente> ClientesPorId(int clienteId)
        {
            throw new NotImplementedException();
        }
    }
}
