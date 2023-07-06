using LepecydLanches.Context;
using LepecydLanches.Models;
using LepecydLanches.Repositories.Interfaces;

namespace LepecydLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
        //Lista de categorias pegando dados da tabela categorias
    }
}
