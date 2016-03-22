using AtividadePraticaDomain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AtividadePraticaRepository.Entity.Mapping
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            ToTable("Produto");

            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            Property(p => p.Valor)
                .IsRequired();
        }
    }
}
