using LepecydLanches.Models;
using Microsoft.EntityFrameworkCore;

namespace LepecydLanches.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {           
        }
        //Tabelas que o EntityFrameWork vai criar
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    }
}
