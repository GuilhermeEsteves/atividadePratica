using System.Collections.Generic;
using System.Web.Mvc;
using AtividadePraticaDomain.Models;

namespace AtividadePratica.ViewModels
{
    public class PedidoViewModel
    {
        public PedidoViewModel(SelectList comboCliente)
        {
            ComboCliente = comboCliente;
        }

        public PedidoViewModel(SelectList comboCliente, IEnumerable<Produto> produtos)
        {
            ComboCliente = comboCliente;
            Produtos = produtos;
        }

        public SelectList ComboCliente { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}