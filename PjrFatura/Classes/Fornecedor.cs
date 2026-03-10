using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class Fornecedor : PessoaJuridica
    {
        public Contato contato { get; set; }
        public String Endereco { get; set; }
        public Fornecedor(
            string razaoSocial, 
            string nomeFantasia, 
            string cnpj,
            Contato contato,
            String Endereco) : base(razaoSocial, nomeFantasia, cnpj)
        {
            this.contato = contato;
            this.Endereco = Endereco;
        }
    }
}
