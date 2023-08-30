using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    class MenuCliente{
    public static void TelaCliente()
    {
            Console.WriteLine("Selecione a opção desejada: ");
            Console.WriteLine("1 - Cadastro de Cliente");
            Console.WriteLine("2 - Consultar Clientes");
            Console.WriteLine("3 - Remover Cadastro");
            Console.WriteLine("4 - Alterar Cadastro");
            Console.WriteLine("5 - Voltar");
            string opcao = Console.ReadLine();

            switch(opcao) 
            {
                case "1":
                    ClienteController.cadastroCliente(); 
                    break;
                case "2":
                    ClienteController.ConsultarCliente();
                    break;
                case "3":
                    ClienteController.RemoverCadastro();
                    break;
                case "4":
                    ClienteController.AlterarCadastro();
                    break;
                case "5":
                    Menu.TelaMenu();
                    break;
            }
    }
}
}





