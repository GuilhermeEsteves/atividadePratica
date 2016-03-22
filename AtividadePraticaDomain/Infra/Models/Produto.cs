using System.Collections.Generic;
using Newtonsoft.Json;

namespace AtividadePraticaDomain.Models
{
    public class Produto : BaseModel
    {
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; } 
    }
}
