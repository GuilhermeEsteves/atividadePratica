using System;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaWebApi.Controllers
{
    public class ClienteController : BaseApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return _clienteService.Get();
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        }
    }
}