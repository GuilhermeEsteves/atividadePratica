using System;
using AtividadePraticaDomain.Infra.Interfaces.Services;
using System.Net.Http;
using System.Web.Http;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaWebApi.Controllers
{
    public class PedidoController : BaseApiController
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public HttpResponseMessage Get(int? codigoCliente = null, 
            DateTime ? dataInicio = null,DateTime? dataFim = null)
        {
            try
            {
                return _pedidoService.Get(codigoCliente, dataInicio, dataFim);
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        }

        [Route("api/Pedido/{codigoPedido}")]
        public HttpResponseMessage Get(int codigoPedido)
        {
            try
            {
                return _pedidoService.Get(codigoPedido);
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        }

        public HttpResponseMessage Post(Pedido pedido)
        {
            try
            {
                return _pedidoService.Post(pedido);
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        }

        [Route("api/Pedido/{codigoPedido}/Items")]
        public HttpResponseMessage GetItems(int codigoPedido)
        {
            try
            {
                return _pedidoService.GetItems(codigoPedido);
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);   
            }
        }
    }
}