using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjLivroCaixa
{
    public class Util
    {

        public static String FormataCpf(String cpf)
        {
            cpf = cpf.Replace(".", "").
                Replace("-", "").
                Replace(" ", "").
                Replace("/", "");

            if (cpf.Length != 11) return "";

            if (!double.TryParse(cpf, out double x)) return "";

            return cpf.Substring(0, 3) + "." +
                   cpf.Substring(3, 3) + "." +
                   cpf.Substring(6, 3) + "-" +
                   cpf.Substring(9, 2);



        }
        public static String ValidaSenha(String senha)
        {
            if (senha.Length < 8)
            {
                return "Número mínimo de 8 caracteres!";
            }
            int nN = 0, nMa = 0, nMi = 0, nE = 0;
            char [] carac = senha.ToCharArray();
            foreach (char c in carac)
            {
                if (c == ' ') return "Espaços não são permitidos";

                if (c >= '0' && c <= '9') nN++;
                else if (c >= 'A' && c <= 'Z') nMa++;
                     else if (c >= 'a' && c <= 'z') nMi++;
                          else nE++;
            }
            if (nN == 0) return "Obrigatório pelo menos um número";
            if (nMi == 0) return "Obrigatório pelo menos uma letra minúscula";
            if (nMa == 0) return "Obrigatório pelo menos uma letra maiúscula";
            if (nE == 0) return "Obrigatório pelo menos um Caracter especial";

            return "";


        }
        public static bool ValidaCnpj(string cnpj)
        {

            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14)
                return false;


            if (cnpj.Distinct().Count() == 1)
                return false;

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;

            tempCnpj += digito1;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;

            string digitosVerificadores = cnpj.Substring(12, 2);
            return digitosVerificadores == $"{digito1}{digito2}";
        }
        public static bool ValidarCPF(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
                return false;

            if (cpf.Distinct().Count() == 1)
                return false;

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (cpf[i] - '0') * (10 - i);

            int primeiroDigito = soma % 11;
            primeiroDigito = primeiroDigito < 2 ? 0 : 11 - primeiroDigito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (cpf[i] - '0') * (11 - i);

            int segundoDigito = soma % 11;
            segundoDigito = segundoDigito < 2 ? 0 : 11 - segundoDigito;

            return cpf[9] - '0' == primeiroDigito && cpf[10] - '0' == segundoDigito;
        }
    }
}
