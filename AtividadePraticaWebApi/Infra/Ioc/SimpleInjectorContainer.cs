using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaDomain.Infra.Interfaces.Services;
using AtividadePraticaDomain.Services;
using AtividadePraticaRepository.Repositories;
using SimpleInjector;

namespace AtividadePraticaWebApi.Infra.Ioc
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Register<IClienteService, ClienteService>();
            container.Register<IClienteRepository,ClienteRepository>();

            container.Register<IProdutoService, ProdutoService>();
            container.Register<IProdutoRepository, ProdutoRepository>();

            container.Register<IPedidoService, PedidoService>();
            container.Register<IPedidoRepository, PedidoRepository>();

            container.Register<ICargaBancoService, CargaBancoService>();

            container.Verify();
            return container;
        } 
    }
}