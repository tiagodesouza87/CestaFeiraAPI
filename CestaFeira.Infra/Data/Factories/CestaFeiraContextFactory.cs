using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CestaFeira.Infra.Data.Factories
{
    public class CestaFeiraContextFactory : IDesignTimeDbContextFactory<CestaFeiraContext>
    {
        public CestaFeiraContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // ou ajustar conforme a pasta raiz
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CestaFeiraContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)
            );

            return new CestaFeiraContext();
        }
    }
}
