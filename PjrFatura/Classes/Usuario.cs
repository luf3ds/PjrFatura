using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjLivroCaixa
{
    [Serializable]
    public class Usuario : IComparable<Usuario>
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public char Perfil { get; private set; }

        private static int contador = 0;

        private String registro;

        public Usuario(String registro) // só serve para busca
        {
            this.registro = registro;
        }

        public static void AcertaContador(List<Usuario> lista)
        {
            if (lista.Count == 0)
            {
                contador = 0;
                return;
            }
            String id = lista[lista.Count - 1].registro;
            int.TryParse(id, out contador);
        }

        public void AlteraSenha(String senha)
        {
            Senha = senha;
        }

        public void Atualiza(String nome, char perfil)
        {
            Nome = nome;
            Perfil = perfil;
        } 

        public Usuario(string nome, string cpf, string login, char perfil)
        {
            Nome = nome;
            Cpf = cpf;
            Login = login;
            Perfil = perfil;
            Senha = cpf;

            registro = (++contador).ToString("D4");
        }

        public override string ToString()
        {
            return String.Concat(registro, ", ",
                Nome, ", ",
                Cpf, ", ",
                Login, ", ",
                Perfil, ", ",
                (Senha.Equals(Cpf) ? "Não trocou senha" : "Trocou senha"));
        }

        int IComparable<Usuario>.CompareTo(Usuario user)
        {
            return registro.CompareTo(user.registro);
        }


    }
}
