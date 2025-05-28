using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaFeira.Domain.Entidades
{
    public class Doacao
    {
        public int IdDoacao { get; set; }        
        public int IdCampanha { get; set; }
        public CampanhaCesta Campanha { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<ItemDoacao> ItensDoacao { get; set; } = new List<ItemDoacao>();
    }
}
