using PrjLivroCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class PessoaJuridica
    {
        public PessoaJuridica(
            string razaoSocial, 
            string nomeFantasia, 
            string cnpj)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;

            if (!Util.ValidaCnpj(Cnpj))
            {
                throw new ArgumentException("CNPJ é inválido: " + cnpj);
            }


        }

        public String RazaoSocial { get; private set; }
        public String NomeFantasia { get; private set; }
        public String Cnpj { get; private set; }


    }
}
