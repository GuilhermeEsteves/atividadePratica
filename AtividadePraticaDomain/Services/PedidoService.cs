using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using AtividadePraticaCommon.Exntensions;
using AtividadePraticaDomain.Infra.Dtos;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Services
{
    public class PedidoService : BaseService, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public HttpResponseMessage Get(int? codigoCliente, DateTime? dataInicio, DateTime? dataFim)
        {
            if ((dataInicio == null && dataFim != null) || (dataInicio != null && dataFim == null))
                return Response(HttpStatusCode.BadRequest, "Preencha as duas datas.");

            if (dataInicio > dataFim)
                return Response(HttpStatusCode.BadRequest, 
                    "Data inicio deve ser menor ou igual a data final");

            dataInicio = dataInicio.MinTimeDay();
            dataFim = dataFim.MaxTimeDay();

            var pedidos = _pedidoRepository.Get(codigoCliente, dataInicio, dataFim);
               
            if(!pedidos.Any())
                return Response(HttpStatusCode.NoContent);

            return Response(HttpStatusCode.OK, 
                pedidos.Select(p => new PedidoDto(p)));
        }

        public HttpResponseMessage Get(int codigoPedido)
        {
            var pedidos = _pedidoRepository.Get(codigoPedido);

            if (!pedidos.Any())
                return Response(HttpStatusCode.NoContent);

            return Response(HttpStatusCode.OK, 
                pedidos.Select(p => new PedidoDto(p)));
        }

        public HttpResponseMessage Post(Pedido pedido)
        {
            if(pedido.IdCliente == 0)
                return Response(HttpStatusCode.BadRequest, "Pedido sem cliente.");

            if (pedido.ItensPedido == null || !pedido.ItensPedido.Any())
                return Response(HttpStatusCode.BadRequest, "Pedido sem items(produtos).");

            if (pedido.DataEntrega.Date < DateTime.Now.Date)
                return Response(HttpStatusCode.BadRequest, "Data de entrega menor que dia atual.");

            _pedidoRepository.Post(pedido);
            return Response(HttpStatusCode.Created);
        }

        public HttpResponseMessage GetItems(int codigoPedido)
        {
            var items = _pedidoRepository.GetItems(codigoPedido);

            if(!items.Any())
                return Response(HttpStatusCode.NoContent);

            return Response(HttpStatusCode.OK, items.Select(i => new ItemPedidoDto(i)));
        }
    }
}