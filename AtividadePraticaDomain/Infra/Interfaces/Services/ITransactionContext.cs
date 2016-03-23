
using System;

namespace AtividadePraticaDomain.Infra.Interfaces.Services
{
    public interface ITransactionContext : IDisposable
    {
        void OpenConnection();
        void Commit();
    }
}