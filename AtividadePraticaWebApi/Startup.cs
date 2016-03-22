using System.Web.Http;
using AtividadePraticaWebApi.Infra.Ioc;
using Owin;
using SimpleInjector.Integration.WebApi;
using Microsoft.Owin.Cors;

namespace AtividadePraticaWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.UseCors(CorsOptions.AllowAll);

            var config = new HttpConfiguration();

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate:"api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional}
            );

            config.DependencyResolver = new 
                SimpleInjectorWebApiDependencyResolver(SimpleInjectorContainer.RegisterServices());

            appBuilder.UseWebApi(config);
        }
    }
}
