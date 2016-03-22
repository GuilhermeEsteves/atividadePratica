using AtividadePraticaDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace AtividadePraticaDomain.Infra.Dtos
{
    public class PedidoDto
    {
        public PedidoDto(Pedido pedido)
        {
            Id = pedido.Id;
            DataEntrega = pedido.DataEntrega.ToShortDateString();
            NomeCliente = pedido.Cliente.Nome;
            ItensPedido = pedido.ItensPedido.Select(i => 
                new ItemPedidoDto(i));
        }

        public int Id { get; set; }

        public string DataEntrega { get; set; }

        public string NomeCliente { get; set; }

        public string ValorTotal
        {
            get { return string.Format("{0:C}",ItensPedido.Sum(i => i.ProdutoDto.Valor * i.Quantidade)); }
        }

        [JsonIgnore]
        public IEnumerable<ItemPedidoDto> ItensPedido { get; set; }
    }
}
