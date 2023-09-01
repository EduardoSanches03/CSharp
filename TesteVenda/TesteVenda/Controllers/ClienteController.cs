using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    class ClienteController
    {

        public static List<Cliente> listaClientes = new List<Cliente>();
        public static void cadastroCliente()
        {
            Cliente cliente = new();
            Console.WriteLine("Informe o nome do Cliente: ");
            cliente.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade do Cliente: ");
            cliente.Idade = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Cliente: ");
            cliente.Cpf = Console.ReadLine();

            listaClientes.Add(cliente);

            Console.WriteLine("----------\n" + cliente.Nome + " cadastrado com sucesso!!\n----------");


            MenuCliente.TelaCliente();
        }
        public static void ConsultarCliente()
        {
            Console.WriteLine("Lista de Clientes: ");
            Console.WriteLine("");
            foreach (var cliente in ClienteController.listaClientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome + " | Idade: " + cliente.Idade + " | CPF: " + cliente.Cpf);
                Console.WriteLine("----------------------------------------------------");
            }

            MenuCliente.TelaCliente();
        }
        public static void RemoverCadastro()
        {
            Console.WriteLine("Informe o CPF do Cliente que deseja remover: ");
            string cpf = Console.ReadLine();

            List<Cliente> novaListaClientes = new List<Cliente>();

            foreach (var cliente in ClienteController.listaClientes)
            {
                if (cpf != cliente.Cpf)
                {
                    novaListaClientes.Add(cliente);
                }
            }

            ClienteController.listaClientes = novaListaClientes;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Cliente removido com sucesso!");
            Console.WriteLine("-----------------------------");

            MenuCliente.TelaCliente();
        }
        public static void AlterarCadastro()
        {
            Console.WriteLine("Informe o CPF do cliente que deseja atualizar: ");
            string altercpf = Console.ReadLine();

            Cliente clienteExistente = listaClientes.FirstOrDefault(cliente => cliente.Cpf == altercpf);

            if (clienteExistente != null)
            {
                Console.WriteLine("Informe o nome do Cliente: ");
                clienteExistente.Nome = Console.ReadLine();
                Console.WriteLine("Informe a idade do Cliente: ");
                clienteExistente.Idade = Console.ReadLine();

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Cliente {clienteExistente.Nome} atualizado com sucesso!!");
                Console.WriteLine("----------------------------------------------------");
            }    
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Cliente não encontrado!");
                Console.WriteLine("-----------------------");
            }

            MenuCliente.TelaCliente();
        }
    }
    }

