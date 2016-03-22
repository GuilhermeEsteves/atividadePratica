using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;

namespace AtividadePraticaService.Services
{
    public class BaseService
    {
        public HttpResponseMessage CallApiGet(string uri, string url, params object[] parametros)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/Json"));

                foreach (var param in parametros)
                    url += "/" + param;

                return client.GetAsync(url).Result;
            }
        }

        public HttpResponseMessage CallApiGet(string uri, string url, object parametros)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/Json"));

                return client.GetAsync(url + ToQueryString(parametros)).Result;
            }
        }

        private string ToQueryString(object parametros)
        {
            var query = "?";
            foreach (var param in parametros.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public))
                query += string.Format("{0}={1}&", param.Name, param.GetValue(parametros, null));

            return query;
        }
    }
}