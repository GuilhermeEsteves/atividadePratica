using AtividadePraticaDomain.Models;

namespace AtividadePraticaDomain.Infra.Dtos
{
    public class ProdutoDto
    {
        public ProdutoDto(Produto produto)
        {
            Id = produto.Id;
            Descricao = produto.Descricao;
            Valor = produto.Valor;
        }

        public ProdutoDto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }

        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }
    }
}