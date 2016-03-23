using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;
using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Services
{
    public class CargaBancoService : BaseService, ICargaBancoService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;

        public CargaBancoService(IClienteRepository clienteRepository, 
            IProdutoRepository produtoRepository)
        {
            _clienteRepository = clienteRepository;
            _produtoRepository = produtoRepository;
        }

        public HttpResponseMessage LoadBanco()
        {
            if(_clienteRepository.TableLoad())
                return Response(HttpStatusCode.OK,"Tabelas já carregadas.");

            #region * Mock Cliente *

            var clientes = new List<Cliente>()
            {
                new Cliente("Esteves", 123456),
                new Cliente("Lara", 123456),
                new Cliente("Basali", 123456),
                new Cliente("Thiagao", 123456),
                new Cliente("Izamara Jordao", 123456),
                new Cliente("Marcio Junqueira", 123456),
                new Cliente("Fernanda", 123456),
                new Cliente("Brenda", 123456),
                new Cliente("Jessika", 123456)
            };

            _clienteRepository.Post(clientes);

            #endregion

            #region * Mock Produto *

            var produtos = new List<Produto>()
            {
                new Produto("Playstation 4", 4000),
                new Produto("Camisa Polo", 120),
                new Produto("Iphone 5", 1500),
                new Produto("Calça Jeans", 89),
                new Produto("Sapato", 100),
                new Produto("Chinelo", 400),
                new Produto("Moto 600cc", 26000),
                new Produto("Computador", 999),
                new Produto("TV", 3000),
                new Produto("Video Cassete", 50),
                new Produto("Telefone Fax", 98)
            };

            _produtoRepository.Post(produtos);

            #endregion

            return Response(HttpStatusCode.OK);
        }
    }
}
