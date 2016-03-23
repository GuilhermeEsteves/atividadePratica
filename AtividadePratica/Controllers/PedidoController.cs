using System;
using System.Web.Mvc;
using AtividadePraticaService.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using AtividadePratica.ViewModels;
using AtividadePraticaDomain.Models;

namespace AtividadePratica.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IProdutoService _produtoService;

        public PedidoController(IClienteService clienteService, IProdutoService produtoService)
        {
            _clienteService = clienteService;
            _produtoService = produtoService;
        }

        public ActionResult Pesquisa()
        {
            try
            {
                var response = _clienteService.Get();

                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    ViewBag.Error = "Falha ao carrgar a tela de pesquisa de pedido";
                    return View("Error");
                }
                
                var clientes = JsonConvert.DeserializeObject<IEnumerable<Cliente>>
                    (response.Content.ReadAsStringAsync().Result);

                var pedidoModel = new PedidoViewModel(
                        new SelectList(clientes, "Id", "Nome")
                    );

                return View(pedidoModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }

        public ActionResult Vendas()
        {
            try
            {
                var responseCliente = _clienteService.Get();
                if (responseCliente.StatusCode == HttpStatusCode.InternalServerError)
                {
                    ViewBag.Error = "Falha ao carregar combo de cliente";
                    return View("Error");
                }

                var clientes = JsonConvert.DeserializeObject<IEnumerable<Cliente>>
                    (responseCliente.Content.ReadAsStringAsync().Result);

                var responseProduto = _produtoService.Get();
                if (responseProduto.StatusCode == HttpStatusCode.InternalServerError)
                {
                    ViewBag.Error = "Falha ao carregar combo de produto";
                    return View("Error");
                }

                var produtos = JsonConvert.DeserializeObject<IEnumerable<Produto>>
                    (responseProduto.Content.ReadAsStringAsync().Result);

                var pedidoModel = new PedidoViewModel(
                        new SelectList(clientes, "Id", "Nome"),
                        produtos
                    );

                return View(pedidoModel);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("PageErro", ex.Message);
            }
        }
    }
}