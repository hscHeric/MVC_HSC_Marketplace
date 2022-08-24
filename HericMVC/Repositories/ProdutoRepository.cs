using HericMVC.Context;
using HericMVC.Models;
using HericMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HericMVC.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);
        public IEnumerable<Produto> ProdutosDestaques => _context.Produtos
                                    .Where(i => i.IsProdutoPreferido)
                                    .Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(z => z.ProdutoId == produtoId);
        }
    }
}
