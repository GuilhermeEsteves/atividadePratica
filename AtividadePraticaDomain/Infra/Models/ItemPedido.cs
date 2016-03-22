
namespace AtividadePraticaDomain.Models
{
    public class ItemPedido : BaseModel
    {
        public int IdProduto { get; set; }

        public int IdPedido { get; set; }

        public decimal Quantidade { get; set; }

        public virtual Pedido Pedido { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
