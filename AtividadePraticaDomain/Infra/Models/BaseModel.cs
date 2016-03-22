using Newtonsoft.Json;

namespace AtividadePraticaDomain.Models
{
    public class BaseModel
    {
        [JsonProperty(Order = 1)]
        public int Id { get; set; }
    }
}