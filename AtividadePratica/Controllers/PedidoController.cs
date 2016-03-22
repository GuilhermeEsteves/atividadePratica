using System;
using System.Web.Mvc;
using AtividadePraticaService.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
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

                if (response.IsSuccessStatusCode)
                {
                    var clientes = JsonConvert.DeserializeObject<IEnumerable<Cliente>>
                        (response.Content.ReadAsStringAsync().Result);

                    var pedidoModel = new PedidoViewModel(
                            new SelectList(clientes, "Id", "Nome")
                        );

                    return View(pedidoModel);
                }

                return PartialView("Error","Falha ao carrgar a tela de pesquisa de pedido");
            }
            catch (Exception ex)
            {
                return View("Error",ex.Message);
            }
        }

        public ActionResult Vendas()
        {
            try
            {
                var responseCliente = _clienteService.Get();
                if (!responseCliente.IsSuccessStatusCode)
                    return View("Error", "Falha ao carregar combo de cliente");

                var clientes = JsonConvert.DeserializeObject<IEnumerable<Cliente>>
                    (responseCliente.Content.ReadAsStringAsync().Result);

                var responseProduto = _produtoService.Get();
                if (!responseProduto.IsSuccessStatusCode)
                    return View("Error", "Falha ao carregar combo de produto");

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
                return View("Error", ex.Message);
            }
        }
    }
}