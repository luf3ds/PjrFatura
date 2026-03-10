using PrjLivroCaixa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class Contato
    {
        public Contato(
            string nome, 
            string cpf, 
            string telFixo, 
            string telMovel, 
            string email, 
            string cargo)
        {
            Nome = nome;
            Cpf = cpf;
            TelFixo = telFixo;
            TelMovel = telMovel;
            Email = email;
            Cargo = cargo;

            if (!Util.ValidarCPF(cpf))
            {
                throw new ArgumentException("CPF Inválido: " + cpf);
            }
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string TelFixo { get; private set; }
        public string TelMovel { get; private set; }
        public String Email { get; private set; }
        public String Cargo { get; private set; }

    }
}
