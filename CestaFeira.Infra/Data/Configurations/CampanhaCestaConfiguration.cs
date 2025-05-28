using CestaFeira.Domain.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CestaFeira.Infra.Data.Configurations
{
    public class CampanhaCestaConfiguration : IEntityTypeConfiguration<CampanhaCesta>
    {
        public void Configure(EntityTypeBuilder<CampanhaCesta> builder)
        {
            builder.HasKey(c => c.IdCampanha);

            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasMaxLength(70);

            builder.Property(c => c.Descricao)
                   .HasMaxLength(300);

            builder.Property(c => c.QuantidadeCestas)
                   .IsRequired();

            builder.Property(c => c.Situacao)
                   .IsRequired();
        }
    }
}
