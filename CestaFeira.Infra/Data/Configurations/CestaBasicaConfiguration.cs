using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CestaFeira.Infra.Data.Configurations
{
    public class CestaBasicaConfiguration : IEntityTypeConfiguration<CestaBasica>
    {
        public void Configure(EntityTypeBuilder<CestaBasica> builder)
        {
            builder.HasKey(c => c.IdCestaBasica);

            builder.Property(c => c.Nome)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Descricao)
                   .HasMaxLength(300);

            builder.Property(c => c.Situacao)
                   .IsRequired();

            builder.HasOne(i => i.Campanha)
               .WithMany(c => c.CestasBasicas)
               .HasForeignKey(i => i.IdCampanha)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
