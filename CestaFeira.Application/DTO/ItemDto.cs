using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Application.DTO
{
    public record ItemDto(int Id, string Nome, string Descricao, SituacaoCadastro Situacao);
}
