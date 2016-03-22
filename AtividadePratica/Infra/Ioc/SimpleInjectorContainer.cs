using System.Reflection;
using AtividadePraticaService.Interfaces;
using AtividadePraticaService.Services;
using SimpleInjector;

namespace AtividadePratica.Infra.Ioc
{
    public class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {
            var container = new Container();

            container.Register<IClienteService,ClienteService>();
            container.Register<IProdutoService,ProdutoService>();
            container.Verify();
            return container;
        }
    }
}