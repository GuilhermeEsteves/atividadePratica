using AtividadePraticaDomain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AtividadePraticaRepository.Entity.Mapping
{
    public class PedidoMapping : EntityTypeConfiguration<Pedido>
    {
        public PedidoMapping()
        {
            ToTable("Pedido");

            HasKey(p => p.Id);

            Property(p => p.DataEntrega)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente);
        }
    }
}
