using System.Collections.Generic;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Models;
using System.Linq;

namespace AtividadePraticaRepository.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        public IEnumerable<Produto> Get()
        {
            using (var context = new Context())
                return context.DbProduto.ToList();
        }

        public void Post(List<Produto> produtos)
        {
            using (var context = new Context())
            {
                context.DbProduto.AddRange(produtos);
                context.SaveChanges();
            }
        } 
    }
}