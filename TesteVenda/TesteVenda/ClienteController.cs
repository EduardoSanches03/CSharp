using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    class ClienteController
    {
         public static void cadastroCliente()
    {

        Cliente cliente = new();

        Console.WriteLine("Informe o nome do Cliente: ");
        cliente.Nome = Console.ReadLine();
        Console.WriteLine("Informe a idade do Cliente: ");
        cliente.Idade = Console.ReadLine();
        Console.WriteLine("Informe o CPF do Cliente: ");
        cliente.Cpf = Console.ReadLine();

    }
    }
}
