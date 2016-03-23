using System.Linq;
using System.Net;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Dtos;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaDomain.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public HttpResponseMessage Get()
        {
            var produtos = _produtoRepository.Get();

            return Response(HttpStatusCode.OK, 
                produtos.Select(p => new ProdutoDto(p)));
        } 
    }
}