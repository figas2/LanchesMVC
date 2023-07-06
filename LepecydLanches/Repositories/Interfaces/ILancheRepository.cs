using LepecydLanches.Models;

namespace LepecydLanches.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche getLancheById(int lancheId);
    }
}
