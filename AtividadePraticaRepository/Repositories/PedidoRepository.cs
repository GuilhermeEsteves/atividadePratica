using System;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AtividadePraticaRepository.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        public IEnumerable<Pedido> Get(int? codigoCliente, DateTime? dataInicio, DateTime? dataFim)
        {
            using (var context = new Context())
                return context.DbPedido.Where(p => (p.IdCliente == codigoCliente || codigoCliente == null)
                            &&  ((p.DataEntrega >= dataInicio.Value && p.DataEntrega <= dataFim.Value)
                                   || (dataInicio == null || dataFim == null)))
                        .Include(p => p.ItensPedido.Select(i => i.Produto))
                        .Include(p => p.Cliente).ToList();
        }

        public IEnumerable<Pedido> Get(int codigoPedido)
        {
            using (var context = new Context())
                return context.DbPedido.Where(p => p.Id == codigoPedido)
                    .Include(p => p.ItensPedido.Select(i => i.Produto))
                    .Include(p => p.Cliente).ToList();
        }

        public IEnumerable<ItemPedido> GetItems(int codigoPedido)
        {
            using (var context = new Context())
                return context.DbItemPedido.
                    Where(i => i.IdPedido == codigoPedido)
                    .Include(i => i.Produto).ToList();
        } 

        public void Post(Pedido pedido)
        {
            using (var context = new Context())
            {
                context.DbPedido.Add(pedido);
                context.SaveChanges();
            }
        }
    }
}