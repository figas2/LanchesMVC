using LepecydLanches.Models;

namespace LepecydLanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; } //apenas leitura

    }
}
