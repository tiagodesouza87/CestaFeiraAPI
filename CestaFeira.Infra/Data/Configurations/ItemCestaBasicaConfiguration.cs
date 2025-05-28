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
    public class ItemCestaBasicaConfiguration : IEntityTypeConfiguration<ItemCestaBasica>
    {
        public void Configure(EntityTypeBuilder<ItemCestaBasica> builder)
        {
            builder.HasKey(c => c.IdItemCestaBasica);

            builder.Property(c => c.Quantidade)
                   .IsRequired();

            builder.HasOne(i => i.Cesta)
               .WithMany(c => c.ItemsCesta)
               .HasForeignKey(i => i.IdCestaBasica)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
