using AtividadePraticaDomain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AtividadePraticaRepository.Entity.Mapping
{
    public class ItemPedidoMapping : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMapping()
        {
            ToTable("ItemPedido");

            HasKey(i => i.Id);

            Property(i => i.Quantidade)
                .IsRequired();

            HasRequired(i => i.Pedido)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(i => i.IdPedido);

            HasRequired(i => i.Produto)
                .WithMany(p => p.ItensPedido)
                .HasForeignKey(i => i.IdProduto);
        }
    }
}
