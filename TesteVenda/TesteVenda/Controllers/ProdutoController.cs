using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class ProdutoController
    {
        public static List<Produto> listaProdutos = new List<Produto>();
        public static void CadastroProduto()
        {
            Produto produto = new();

            produto.Codigo = Config.GerarIDAleatorio();
            Console.WriteLine("Informe o Nome do Produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto: ");
            produto.Valor = double.Parse(Console.ReadLine());

            listaProdutos.Add(produto);

            Console.WriteLine("----------\n" + produto.Nome + " cadastrado com sucesso!!\n----------");

            MenuProduto.TelaProduto();
        }
        public static void ConsultarProduto()
        {
            Console.WriteLine("Lista de Produtos: ");
            Console.WriteLine("");
            foreach (var produto in listaProdutos)
            {
                Console.WriteLine("Código: " + produto.Codigo + " | Nome: " + produto.Nome + " | Valor: R$" + produto.Valor);
                Console.WriteLine("----------------------------------------------------");
            }
            
            MenuProduto.TelaProduto();
        }
        public static void RemoverProduto()
        {
            Console.WriteLine("Informe o codigo do Produto que deseja remover: ");
            string id = Console.ReadLine();

            List<Produto> novaListaProdutos = new List<Produto>();

            foreach (var produto in listaProdutos)
            {
                if (id != produto.Codigo)
                {
                    novaListaProdutos.Add (produto);
                }
            }

            listaProdutos = novaListaProdutos;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Produto removido com sucesso!");
            Console.WriteLine("-----------------------------");

            MenuProduto.TelaProduto();
        }
        public static void AtualizarProduto()
        {
            Console.WriteLine("Informe o código do produto que deseja atualizar: ");
            string altercod = Console.ReadLine();

            Produto produtoExistente = listaProdutos.FirstOrDefault(produto => produto.Codigo == altercod);

                if (produtoExistente != null)
                {
                    Console.WriteLine("Informe o nome do produto: ");
                    produtoExistente.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o valor do produto1; ");
                    produtoExistente.Valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine($"Produto {produtoExistente.Nome} atualizado com sucesso!!");
                    Console.WriteLine("----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Produto não encontrado!");
                    Console.WriteLine("-----------------------");
                }

                MenuProduto.TelaProduto();
            }
    }
}
