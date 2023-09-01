using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class MenuVenda
    {
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static List<Produto> listaProdutos = new List<Produto>();
        public static void TelaVenda()
        {
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Registrar Venda");
            Console.WriteLine("2 - Consultar Vendas");
            Console.WriteLine("3 - Cancelar Venda");
            Console.WriteLine("5 - Voltar");
            string opcao = Console.ReadLine();

            
            switch (opcao)
            {
                case "1":
                    VendaController.RealizarVenda();
                    break;
                case "2":
                    VendaController.ConsultarPedidos();
                    break;
                case "3":
                    VendaController.CancelarPedido();
                    break;
                case "5":
                    Menu.TelaMenu();
                    break;
            }
        }
    }
}
