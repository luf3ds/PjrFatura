using PrjCalculadoraWeb.Classes;
using PrjFatura.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjFatura
{
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }

        private void btCadastraClientes_Click(object sender, EventArgs e)
        {
           
            try
            {

                Contato joca = new Contato("Joaquim José",
                   "601.843.950-62", "",
                   "(13) 9 7890 3345",
                   "joca.joca@yahoo.com", "Vendedor");

                Contato cecilia = new Contato("Cecilia Maria",
                   "228.242.130-27", "",
                   "(13) 9 7777 8888",
                   "joca.joca@yahoo.com", "Vendedor");

                List<Fornecedor> fornecedores = new List<Fornecedor>();
                Fornecedor f1 = new Fornecedor("Coca Cola Distribuidora de Bebidas SA", "Coca Cola",
                    "51.158.327/0001-27", joca, "Ana Costa 2000, Santos/SP");
                fornecedores.Add(f1);

                // Mais 5 fornecedores aqui

                Serializa.SerializaFornecedor(fornecedores, "dadosFornecedor.Dat");

                List<Apresentacao> apresentacoes = new List<Apresentacao>();

                Apresentacao lata350 = new Apresentacao("Lata 350ml", 355);
                apresentacoes.Add(lata350);

                // Mais (pelo menos) 9 apresentações

                Serializa.SerializaApresentacao(apresentacoes, "dadosApresentacao;Dat");

                List<Produto> produtos = new List<Produto>();

                produtos.Add(new Produto("Coca Lata 350",f1,lata350,4.8m,1000));

                // Mais 29 produtos

                Serializa.SerializaProduto(produtos, "dadosProdutos.dat");











                List<Cliente> clientes = new List<Cliente>();

                Contato helio = new Contato("Helio Rangel", 
                    "323.692.807-78", "",
                    "(13) 9 9767 5502", 
                    "halrangel@yahoo.com.br", "Prof");


                Contato maria = new Contato("Maria José",
                   "106.224.550-44",
                   "", "(13) 9 8765 8877", 
                   "maria.jose@yahoo.com", "Secretária");


                Cliente c1 = new Cliente("Bar e Restaurante do José LTDA",
                                        "Bar do Zé", "59.434.141/0001-65");
                c1.contato = helio;
                c1.Endereco = "Av Ana Costa 234, Santos/SP";
                c1.AddLimite(10000);
                clientes.Add(c1);

                Cliente c2 = new Cliente("Restaurante Massa Caseira LTDA", "Cantina do Luiz", "95.991.837/0001-56");
                c2.AddLimite(10000);
                c2.Endereco = "Av. Ana Costa, 2387, Santos/SP";
                c2.contato = helio;
                clientes.Add(c2);

                Cliente c3 = new Cliente("Restaurante e Pizzaria Mama Elisa LTDA", "Mama Elisa", "99.630.612/0001-25");
                c3.AddLimite(10000);
                c3.Endereco = "Av. Senador Feijó, 306, Santos/SP";
                c3.contato = helio;
                clientes.Add(c3);

                Cliente c4 = new Cliente("Adega da Vila LTDA", "Adega da Vila", "07.676.422/0001-20");
                c4.AddLimite(15000);
                c4.Endereco = "Carvalho de Mendonça, 2000, Santos/SP";
                c4.contato = maria;
                clientes.Add(c4);

                Cliente c5 = new Cliente("Super Mercados Ypiranga SA", "Ypiranga", "30.125.492/0001-02");
                c5.AddLimite(25000);
                c5.Endereco = "Av. São João, 2070, São Paulo/SP";
                c5.contato = maria;
                clientes.Add(c5);

                Cliente c6 = new Cliente("Distribuidora de bebidas São José LTDA", "São José", "78.502.354/0001-21");
                c6.AddLimite(25000);
                c6.Endereco = "Av. Paulista, 1287, São Paulo/SP";
                c6.contato = maria;
                clientes.Add(c6);

                Serializa.SerializaCliente(clientes, "dadosClientes.dat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deu Ruim");
            }
        }
    }
}
