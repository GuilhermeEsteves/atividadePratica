using System.Collections.Generic;
using System.Net.Http;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Interfaces.Services
{
    public interface IProdutoService
    {
        HttpResponseMessage Get();
    }
}