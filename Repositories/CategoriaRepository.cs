using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiTech.Context;
using TiTech.Repositories.Interfaces;

namespace TiTech.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;

        public IEnumerable<Categoria> CategoriasPorId(int categoriaId)
        {
            yield return _context.Categorias.FirstOrDefault(cat => cat.Id == categoriaId);
        }
    }
}
