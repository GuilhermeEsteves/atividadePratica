using System;
using System.Net.Http;
using AtividadePraticaDomain.Infra.Interfaces.Services;

namespace AtividadePraticaWebApi.Controllers
{
    public class CargaBancoController : BaseApiController
    {
        private readonly ICargaBancoService _cargaBancoService;

        public CargaBancoController(ICargaBancoService cargaBancoService)
        {
            _cargaBancoService = cargaBancoService;
        }

        public HttpResponseMessage Post()
        {
            try
            {
                return _cargaBancoService.LoadBanco();
            }
            catch (Exception ex)
            {
                return ResponseError(ex.Message);
            }
        }
    }
}