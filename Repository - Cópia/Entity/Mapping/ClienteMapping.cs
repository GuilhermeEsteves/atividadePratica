using System.Data.Entity.ModelConfiguration;
using Repository.Models;

namespace Repository.Entity.Mapping
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
