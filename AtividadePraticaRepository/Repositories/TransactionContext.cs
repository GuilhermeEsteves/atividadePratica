using System;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaRepository.Repositories
{
    public class TransactionContext : ITransactionContext
    {
        private Context Context { get; set; }

        public void OpenConnection()
        {
            Context = new Context();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
