using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using AtividadePraticaWebApi.Infra.Ioc;
using Microsoft.Owin.Hosting;
using SimpleInjector;
using AtividadePraticaDomain.Infra.Interfaces.Repository;
using AtividadePraticaRepository.Repositories;

namespace AtividadePraticaWebApi
{
    static class Program
    {
        static void Main()
        {
            #if DEBUG

            WebApp.Start<Startup>("http://localhost:1600");
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
            
            #else

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);

            #endif
        }
    }
}
