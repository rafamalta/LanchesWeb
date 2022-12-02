using Lanches.Context;
using Lanches.Models;
using Lanches.Repositories.Interfaces;

namespace Lanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        // injeção de dependência
        private readonly AppDbContext _context;

        // injeta no construtor uma instância e atribui um contexto
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        // usa a instância do contexto para acessar a tabela 'Categorias' e retorna uma lista da mesma
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
