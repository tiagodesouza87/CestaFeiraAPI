using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Application.DTO
{
    public record CampanhaCestaDto(int Id, string Nome, string Descricao, int QuantidadeCestas, SituacaoCampanha Situacao);
}
