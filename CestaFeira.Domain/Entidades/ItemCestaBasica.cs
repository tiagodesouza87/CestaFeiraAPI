using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestaFeira.Domain.Entidades
{
    public class ItemCestaBasica
    {
        public int IdItemCestaBasica { get; set; }        
        public int Quantidade { get; set; }

        public int IdItem { get; set; }
        public Item Item { get; set; }
        public int IdCestaBasica { get; set; }
        public CestaBasica Cesta { get; set; }

        public ICollection<ItemDoacao> ItensDoacao { get; set; } = new List<ItemDoacao>();
    }
}
