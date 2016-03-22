using System;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaWebApi.Controllers
{
    public class ProdutoController : BaseApiController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return _produtoService.Get();
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        } 
    }
}