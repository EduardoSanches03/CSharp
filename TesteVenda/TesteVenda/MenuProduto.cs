using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class MenuProduto
    {
        public static void TelaProduto()
        {
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Cadastro de Produto");
            Console.WriteLine("2 - Consultar Produto");
            Console.WriteLine("3 - Remover Produto");
            Console.WriteLine("4 - Alterar Cadastro do Produto");
            Console.WriteLine("5 - Voltar");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ProdutoController.CadastroProduto();
                    break;
                case "2":
                    ProdutoController.ConsultarProduto();
                    break;
                case "3":
                    ProdutoController.RemoverProduto();
                    break;
                case "4":
                    ProdutoController.AtualizarProduto();
                    break;
                case "5":
                    Menu.TelaMenu();
                    break;
            }
        }
    }
}
