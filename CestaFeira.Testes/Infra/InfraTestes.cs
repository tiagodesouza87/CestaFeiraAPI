using CestaFeira.Domain.Entidades;
using CestaFeira.Infra.Data;

namespace CestaFeira.Testes.Infra
{
    public class InfraTestes :IClassFixture<DbContextFixture>
    {
        private readonly CestaFeiraContext _context;

        public InfraTestes(DbContextFixture fixture)
        {
            _context = fixture.Context;
        }
        [Fact]
        public void AddItensTeste()
        {
            Item item = new Item
            {
                Descricao = "Pacote de 1kg de arroz.",
                Nome = "Arroz",
                Situacao = Domain.Enum.SituacaoCadastro.Ativo,
                Unidade = "kg"
            };
            _context.Itens.Add(item);
            _context.SaveChanges();

            Assert.True(item.IdItem > 0);
        }
    }
}