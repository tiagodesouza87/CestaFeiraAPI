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
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(c => c.IdUsuario);

            builder.Property(c => c.Login)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Senha)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.NivelAcessoUsuario)
                   .IsRequired();

            builder.Property(c => c.CpfCnpj)
                   .IsRequired()
                   .HasMaxLength(14);

            builder.Property(c => c.Situacao)
                   .IsRequired();
        }
    }
}
