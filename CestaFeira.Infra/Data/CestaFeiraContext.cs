using CestaFeira.Domain.Entidades;
using CestaFeira.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace CestaFeira.Infra.Data
{
    public class CestaFeiraContext : DbContext
    {
        public DbSet<Item> Itens { get; set; }
        public DbSet<CampanhaCesta> Campanhas { get; set; }
        public DbSet<CestaBasica> CestasBasicas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<ItemCestaBasica> ItensCestaBasica { get; set; }
        public DbSet<ItemDoacao> ItensDoacao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        private readonly IConfiguration _configuration;

        public CestaFeiraContext() {
            _configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())  // Define o diretório base
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  // Adiciona o appsettings.json
            .Build();
        }                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(_configuration.GetConnectionString("DefaultConnection"),
            ServerVersion.AutoDetect(_configuration.GetConnectionString("DefaultConnection"))
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CampanhaCestaConfiguration());
            modelBuilder.ApplyConfiguration(new CestaBasicaConfiguration());
            modelBuilder.ApplyConfiguration(new DoacaoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemCestaBasicaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
            modelBuilder.ApplyConfiguration(new ItemDoacaoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CestaFeiraContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }

}
