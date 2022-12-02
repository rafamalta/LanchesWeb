using Lanches.Models;

namespace Lanches.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        // lista de 'Categorias' somente como leitura de forma ordenada
        IEnumerable<Categoria> Categorias { get; }
    }
}
