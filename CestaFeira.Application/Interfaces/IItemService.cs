using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Application.DTO;

namespace CestaFeira.Application.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemDto>> GetAllAsync();
        Task<ItemDto> GetByIdAsync(Guid id);
        Task CreateAsync(ItemDto dto);
        Task UpdateAsync(ItemDto dto);
        Task DeleteAsync(Guid id);
    }
}
