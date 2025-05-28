using CestaFeira.Domain.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CestaFeira.Infra.Data.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.IdItem);

            builder.Property(i => i.Nome)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(i => i.Descricao)
                   .HasMaxLength(120);

            builder.Property(i => i.Situacao)
                   .IsRequired();
        }
    }
}
