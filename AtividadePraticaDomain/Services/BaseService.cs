using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using Newtonsoft.Json;

namespace AtividadePraticaDomain.Services
{
    public class BaseService
    {
        public HttpResponseMessage Response<T>(HttpStatusCode statusCode, T content)
        {
            return new HttpResponseMessage(statusCode)
            {
                Content = new ObjectContent(
                    content.GetType(),
                    content,
                    new JsonMediaTypeFormatter()
                    {
                        SerializerSettings = new JsonSerializerSettings()
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        }
                    }
                )
            };
        }

        public HttpResponseMessage Response(HttpStatusCode statusCode, string message = "")
        {
            return new HttpResponseMessage(statusCode)
            {
                Content = new ObjectContent(
                   message.GetType(),
                   message,
                   new JsonMediaTypeFormatter()
                   {
                       SerializerSettings = new JsonSerializerSettings()
                       {
                           NullValueHandling = NullValueHandling.Ignore,
                           ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                       }
                   }
               )
            };
        }
    }
}