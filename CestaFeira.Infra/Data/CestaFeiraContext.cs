using CestaFeira.Domain.Entidades;
using CestaFeira.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CestaFeira.Infra.Data
{
    public class CestaFeiraContext : DbContext
    {
        public CestaFeiraContext(DbContextOptions<CestaFeiraContext> options) : base(options) { }
        public DbSet<Item> Itens { get; set; }
        public DbSet<CampanhaCesta> Campanhas { get; set; }
        public DbSet<CestaBasica> CestasBasicas { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<ItemCestaBasica> ItensCestaBasica { get; set; }
        public DbSet<ItemDoacao> ItensDoacao { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySql()
        //}
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
