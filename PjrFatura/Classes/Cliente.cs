using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class Cliente : PessoaJuridica
    {
        public String Endereco { get; set; }

        public Contato contato;

        private Decimal LimiteDeCredito = 0m;

        public void AddLimite(Decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor não pode ser negativo!");
            }
            LimiteDeCredito += valor;
        }

        public void SubLimite(Decimal valor)
        {
            if (valor > LimiteDeCredito)
            {
                throw new ArgumentException("Crédito insuficiente!");
            }
            LimiteDeCredito -= valor;
        }

        public Cliente(
            string razaoSocial, 
            string nomeFantasia, 
            string cnpj) : 
            base(
                razaoSocial, 
                nomeFantasia, 
                cnpj)
        {
             
        }
    }
}
