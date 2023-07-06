using LepecydLanches.Context;
using LepecydLanches.Models;
using LepecydLanches.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LepecydLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c=>c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p =>
            p.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche getLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l=>
            l.LancheId == lancheId);
    }
}
