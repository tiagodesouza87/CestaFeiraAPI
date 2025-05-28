using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Domain.Entidades
{
    public class CestaBasica
    {
        public int IdCestaBasica { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public SituacaoCesta Situacao { get; set; }

        public int IdCampanha { get; set; }
        public CampanhaCesta Campanha { get; set; }
        public ICollection<ItemCestaBasica> ItemsCesta { get; set; }

    }
}
