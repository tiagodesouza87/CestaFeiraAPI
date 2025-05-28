using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Domain.Entidades
{
    public class Item
    {
        public Guid IdItem { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public SituacaoCadastro Situacao { get; set; }
        public string Unidade { get; set; }
    }
}
