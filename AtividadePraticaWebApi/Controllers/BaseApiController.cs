using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace AtividadePraticaWebApi.Controllers
{
    public class BaseApiController : ApiController
    {
        public HttpResponseMessage ResponseError(string mensage, 
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        {
            return new HttpResponseMessage(statusCode)
            {
                Content = new ObjectContent(
                    typeof(string),
                    mensage,
                    new JsonMediaTypeFormatter()
                )
            };
        }
    }
}
