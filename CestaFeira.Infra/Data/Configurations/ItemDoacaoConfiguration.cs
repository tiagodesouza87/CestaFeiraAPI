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
    public class ItemDoacaoConfiguration : IEntityTypeConfiguration<ItemDoacao>
    {
        public void Configure(EntityTypeBuilder<ItemDoacao> builder)
        {
            builder.HasKey(i => i.IdItemDoacao);

            builder.Property(i => i.Situacao)
               .IsRequired();

            builder.HasOne(ac => ac.Doacao)
            .WithMany(a => a.ItensDoacao)
            .HasForeignKey(ac => ac.IdDoacaoCestaBasica);
            
            builder.HasOne(ac => ac.ItemCesta)
            .WithMany(a => a.ItensDoacao)
            .HasForeignKey(ac => ac.IdItem);

        }
    }
}
