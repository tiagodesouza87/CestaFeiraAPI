using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaFeira.Domain.Enum;

namespace CestaFeira.Domain.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public SituacaoCadastro Situacao { get; set; }
        public AcessoUsuario NivelAcessoUsuario { get; set; }

        public ICollection<Doacao> Doacoes { get; set; }
    }
}
