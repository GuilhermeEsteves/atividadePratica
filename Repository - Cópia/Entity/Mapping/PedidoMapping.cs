using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Entity.Mapping
{
    public class PedidoMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapping()
        {
            ToTable("Pedido");

            HasKey(p => p.Id);

            Property(p => p.DataEntrega)
                .IsRequired();

            Ignore(p => p.ValorTotal);

            HasRequired(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente);
        }
    }
}
