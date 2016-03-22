using System.Collections.Generic;
using System.Linq;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaRepository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public IEnumerable<Cliente> Get()
        {
            using (var context = new Context())
                return context.DbCliente.ToList();
        }
    }
}