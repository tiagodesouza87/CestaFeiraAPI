using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CestaFeira.Testes
{
    public class DbContextFixture : IDisposable
    {
        public CestaFeiraContext Context { get; }

        public DbContextFixture()
        {
            Context = new CestaFeiraContext();
            Context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            Context.Database.EnsureDeleted();
            Context.Dispose();
        }
    }

}
