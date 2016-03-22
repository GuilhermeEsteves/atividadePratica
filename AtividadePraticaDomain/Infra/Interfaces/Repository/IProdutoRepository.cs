using System.Collections.Generic;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Interfaces.Repository
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Get();
    }
}