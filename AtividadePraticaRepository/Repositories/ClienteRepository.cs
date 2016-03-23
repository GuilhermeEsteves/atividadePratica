using System.Collections.Generic;
using System.Data;
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

        public void Post(List<Cliente> clientes)
        {
            using (var context = new Context())
            {
                context.DbCliente.AddRange(clientes);
                context.SaveChanges();
            }
        }

        public bool TableLoad()
        {
            using (var context = new Context())
                return context.DbCliente.Any();
        }
    }
}