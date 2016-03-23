using System.Linq;
using System.Net;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Dtos;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaDomain.Services
{
    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public HttpResponseMessage Get()
        {
            var clientes = _clienteRepository.Get();

            return Response(HttpStatusCode.OK, 
                clientes.Select(c => new ClienteDto(c)));
        }
    }
}