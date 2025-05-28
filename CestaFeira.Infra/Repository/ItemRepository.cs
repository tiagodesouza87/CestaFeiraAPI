using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Entidades;
using CestaFeira.Domain.Interfaces;
using CestaFeira.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace CestaFeira.Infra.Repository
{
    public class ItemRepository : IItemRepository
    {
        private readonly CestaFeiraContext _context;

        public ItemRepository(CestaFeiraContext context) => _context = context;1
        //public ItemRepository()
        //{
        //    _context = new CestaFeiraContext();
        //    _context.Database.EnsureCreated();
        //}

        public async Task<IEnumerable<Item>> GetAllAsync() => await _context.Itens.ToListAsync();

        public async Task<Item> GetByIdAsync(int id) => await _context.Itens.FindAsync(id);

        public async Task AddAsync(Item item)
        {
            await _context.Itens.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Item item)
        {
            _context.Itens.Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Itens.FindAsync(id);
            if (item is not null)
            {
                _context.Itens.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }

}
