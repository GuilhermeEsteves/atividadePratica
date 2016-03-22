using AtividadePraticaDomain.Models;
using System;
using System.Net.Http;

namespace AtividadePraticaDomain.Infra.Interfaces.Services
{
    public interface IPedidoService
    {
        HttpResponseMessage Get(int? codigoCliente, DateTime? dataInicio, DateTime? dataFim);
        HttpResponseMessage Get(int codigoPedido);
        HttpResponseMessage Post(Pedido pedido);
        HttpResponseMessage GetItems(int codigoPedido);
    }
}