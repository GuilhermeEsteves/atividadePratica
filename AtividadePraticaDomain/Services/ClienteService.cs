using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Dtos;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;
using AtividadePraticaDomain.Models;

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

            if (!clientes.Any())
                return Response(HttpStatusCode.NoContent);

            return Response(HttpStatusCode.OK, 
                clientes.Select(c => new ClienteDto(c)));
        }
    }
}