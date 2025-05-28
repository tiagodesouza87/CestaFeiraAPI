using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Application.DTO;

namespace CestaFeira.Application.Interfaces
{
    public interface ICampanhaCestaService
    {
        Task<IEnumerable<CampanhaCestaDto>> GetAllAsync();
        Task<CampanhaCestaDto> GetByIdAsync(Guid id);
        Task CreateAsync(CampanhaCestaDto dto);
        Task UpdateAsync(CampanhaCestaDto dto);
        Task DeleteAsync(Guid id);
    }
}
