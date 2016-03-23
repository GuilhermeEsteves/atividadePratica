using System.Collections.Generic;

namespace AtividadePraticaDomain.Models
{
    public class Produto : BaseModel
    {
        public Produto()
        {
            
        }

        public Produto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; } 
    }
}
