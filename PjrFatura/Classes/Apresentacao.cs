using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjFatura.Classes
{
    [Serializable]
    public class Apresentacao
    {
        public Apresentacao(string descricao, int peso)
        {
            Descricao = descricao;
            Peso = peso;
        }

        public String Descricao { get; private set; }
        public int Peso { get; private set; }
    }
}
