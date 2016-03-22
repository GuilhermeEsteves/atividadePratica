using System.Net.Http;
using AtividadePraticaService.Interfaces;
using AtividadePraticaService.Infra;

namespace AtividadePraticaService.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public HttpResponseMessage Get()
        {
            return CallApiGet(Api.AtividadePratica.Uri,"api/Produto");
        }
    }
}