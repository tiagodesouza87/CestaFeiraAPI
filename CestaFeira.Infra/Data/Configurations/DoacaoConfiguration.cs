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
    public class DoacaoConfiguration : IEntityTypeConfiguration<Doacao>
    {
        public void Configure(EntityTypeBuilder<Doacao> builder)
        {
            builder.HasKey(c => c.IdDoacao);

            builder.HasOne(i => i.Usuario)
               .WithMany(c => c.Doacoes)
               .HasForeignKey(i => i.IdUsuario)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.Campanha)
               .WithMany(c => c.Doacoes)
               .HasForeignKey(i => i.IdCampanha)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
