using System;
using System.ServiceProcess;
using Microsoft.Owin.Hosting;

namespace AtividadePraticaWebApi
{
    public partial class Service1 : ServiceBase
    {
        private IDisposable _service;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            _service = WebApp.Start<Startup>("http://localhost:1600");
        }

        protected override void OnStop()
        {
            if(_service != null)
                _service.Dispose();

            base.OnStop();
        }
    }
}
