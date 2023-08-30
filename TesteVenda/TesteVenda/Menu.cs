using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Menu
    {
        public static void TelaMenu() 
        {
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Menu Clientes");
            Console.WriteLine("2 - Menu Produtos");
            Console.WriteLine("3 - Menu Venda");
            String opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    MenuCliente.TelaCliente();
                    break;
                case "2":
                    MenuProduto.TelaProduto();
                    break;
                case "3":
                    MenuVenda.TelaVenda();
                break;
            }
        }
        
    }
}
