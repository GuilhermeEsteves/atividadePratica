using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Dtos
{
    public class ItemPedidoDto
    {
        public ItemPedidoDto(ItemPedido itemPedido)
        {
            Id = itemPedido.Id;
            IdProduto = itemPedido.IdProduto;
            IdPedido = itemPedido.IdPedido;
            Quantidade = itemPedido.Quantidade;
            ProdutoDto = new ProdutoDto(itemPedido.Produto);
        }

        public int Id { get; set; }

        public int IdProduto { get; set; }

        public int IdPedido { get; set; }

        public decimal Quantidade { get; set; }

        public decimal ValorTotal
        {
            get { return Quantidade * ProdutoDto.Valor; }
        }

        public ProdutoDto ProdutoDto { get; set; }
    }
}