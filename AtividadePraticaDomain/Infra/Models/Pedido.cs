using System;
using System.Collections.Generic;
namespace AtividadePraticaDomain.Models
{
    public class Pedido : BaseModel
    {
        public DateTime DataEntrega { get; set; }

        public int IdCliente { get; set; }
        
        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
