using AtividadePraticaDomain.Models;
using System;
using System.Collections.Generic;

namespace AtividadePraticaDomain.Infra.Interfaces.Repository
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Get(int? codigoCliente, DateTime? dataInicio, DateTime? dataFim);
        IEnumerable<Pedido> Get(int codigoPedido);
        IEnumerable<ItemPedido> GetItems(int codigoPedido);
        void Post(Pedido pedido);
    }
}