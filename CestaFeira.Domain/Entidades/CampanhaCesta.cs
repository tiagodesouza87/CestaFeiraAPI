using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Domain.Entidades
{
    public class CampanhaCesta
    {
        public int IdCampanha { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QuantidadeCestas { get; set; }
        public SituacaoCampanha Situacao { get; set; }

        public ICollection<CestaBasica> CestasBasicas { get; set; }

        public ICollection<Doacao> Doacoes { get; set; }
    }
}
