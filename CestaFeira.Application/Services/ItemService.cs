using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Application.DTO;
using CestaFeira.Application.Interfaces;
using CestaFeira.Domain.Entidades;
using CestaFeira.Domain.Interfaces;

namespace CestaFeira.Infra.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository) => _repository = repository;

        public async Task<IEnumerable<ItemDto>> GetAllAsync()
            => (await _repository.GetAllAsync()).Select(i => new ItemDto(i.IdItem, i.Nome, i.Descricao, i.Situacao));

        public async Task<ItemDto> GetByIdAsync(int id)
        {
            var item = await _repository.GetByIdAsync(id);
            return new ItemDto(item.IdItem, item.Nome, item.Descricao, item.Situacao);
        }

        public async Task CreateAsync(ItemDto dto)
        {
            var item = new Item { IdItem = 0, Nome = dto.Nome, Descricao = dto.Descricao, Situacao = dto.Situacao };
            await _repository.AddAsync(item);
        }

        public async Task UpdateAsync(ItemDto dto)
        {
            var item = new Item { IdItem = dto.Id, Nome = dto.Nome, Descricao = dto.Descricao, Situacao = dto.Situacao };
            await _repository.UpdateAsync(item);
        }

        public async Task DeleteAsync(int id) => await _repository.DeleteAsync(id);
    }

}
