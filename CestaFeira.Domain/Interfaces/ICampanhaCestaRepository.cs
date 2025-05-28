using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Entidades;

namespace CestaFeira.Domain.Interfaces
{
    public interface ICampanhaCestaRepository
    {
        Task<IEnumerable<CampanhaCesta>> GetAllAsync();
        Task<CampanhaCesta> GetByIdAsync(Guid id);
        Task AddAsync(CampanhaCesta campanha);
        Task UpdateAsync(CampanhaCesta campanha);
        Task DeleteAsync(Guid id);
    }
}
