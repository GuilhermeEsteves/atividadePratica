using AtividadePraticaDomain.Models;
using System.Data.Entity.ModelConfiguration;

namespace AtividadePraticaRepository.Entity.Mapping
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("Cliente");

            HasKey(c => c.Id);

            Property(c => c.Cpf)
                .IsRequired();

            Property(c => c.Nome)
                .IsRequired();

        }
    }
}
