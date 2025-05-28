using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace CestaFeira.Testes
{
    public class DbContextFixture : IDisposable
    {
        public CestaFeiraContext Context { get; }

        public DbContextFixture()
        {
            var options = new DbContextOptionsBuilder<CestaFeiraContext>()
                .UseMySql("Server=localhost;Database=CestaFeiraDb;User=root;Password=firehead;",
                    new MySqlServerVersion(new Version(10, 6, 0)))
                .Options;

            Context = new CestaFeiraContext(options);

            // Garantir que banco existe
            Context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }
    }

}
