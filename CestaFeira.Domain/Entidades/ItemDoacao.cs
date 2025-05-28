using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Domain.Entidades
{
    public class ItemDoacao
    {
        public int IdItemDoacao { get; set; }
        public int IdItem {get; set; }
        public int IdDoacaoCestaBasica {get; set; }
        public SituacaoDoacao Situacao { get; set; }
        public string Observacoes { get; set; }
        public Doacao Doacao { get; set; }
        public ItemCestaBasica ItemCesta { get; set; }
    }
}
