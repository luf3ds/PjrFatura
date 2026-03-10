using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class Produto : IComparable<Produto>
    {
        private static int contador = 0;

        public Produto(
            string nome, 
            Fornecedor fornecedor, 
            Apresentacao apresentacao, 
            decimal preco, 
            int quantidade)
        {
            Nome = nome;
            this.fornecedor = fornecedor;
            this.apresentacao = apresentacao;
            Preco = preco;
            Quantidade = quantidade;
            Codigo = (++contador).ToString("D6");
        }

        public String Codigo { get; private set; }

        public String Nome { get; private set; }

        public Fornecedor fornecedor { get; private set; }

        public Apresentacao apresentacao { get; private set; }

        public Decimal Preco { get; private set; }

        public int Quantidade { get; private set; }

        int IComparable<Produto>.CompareTo(Produto other)
        {
            return Codigo.CompareTo(other.Codigo);
        }
    }
}
