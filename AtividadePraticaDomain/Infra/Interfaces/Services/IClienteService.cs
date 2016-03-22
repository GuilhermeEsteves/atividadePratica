using AtividadePraticaDomain.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace AtividadePraticaDomain.Infra.Interfaces.Services
{
    public interface IClienteService
    {
        HttpResponseMessage Get();
    }
}