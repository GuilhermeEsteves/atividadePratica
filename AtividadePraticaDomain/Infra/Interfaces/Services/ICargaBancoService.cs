using System.Net.Http;

namespace AtividadePraticaDomain.Infra.Interfaces.Services
{
    public interface ICargaBancoService
    {
        HttpResponseMessage LoadBanco();
    }
}