using System.Collections.Generic;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Interfaces.Repository
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Get();
        void Post(List<Cliente> clientes);
        bool TableLoad();
    }
}