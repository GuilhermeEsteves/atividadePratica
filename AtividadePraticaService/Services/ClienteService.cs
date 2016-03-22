using AtividadePraticaService.Infra;
using System.Net.Http;
using AtividadePraticaService.Interfaces;

namespace AtividadePraticaService.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        public HttpResponseMessage Get()
        {
            return CallApiGet(Api.AtividadePratica.Uri, "api/Cliente");
        }
    }
}