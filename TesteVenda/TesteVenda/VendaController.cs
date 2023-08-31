    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace TesteVenda
    {
        internal class VendaController
        {
        public static List<Venda> listaVendas = new List<Venda>();
        public static void RealizarVenda()
        {

            Console.WriteLine("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine();

                Cliente clienteExistente = ClienteController.listaClientes.FirstOrDefault(cliente => cliente.Cpf == cpf);

            if (clienteExistente != null)
            {
                if (cpf == clienteExistente.Cpf)
                {
                    Console.WriteLine("Informe o Código do produto:");
                    string codigo = Console.ReadLine();

                    Produto produtoExistente = ProdutoController.listaProdutos.FirstOrDefault(produto => produto.Codigo == codigo);

                    if(produtoExistente != null)
                    {
                        if(codigo == produtoExistente.Codigo)
                        {
                            Console.WriteLine("Informe a quantidade vendida: ");
                            int quantidade = int.Parse(Console.ReadLine());

                            double valorVenda = quantidade * produtoExistente.Valor;

                            Venda venda = new Venda(clienteExistente, produtoExistente, quantidade, valorVenda)
                            {
                                Id = Config.GerarIDAleatorio(),
                                Cliente = clienteExistente,
                                Produto = produtoExistente,
                                Quantidade = quantidade,
                                ValorVenda = valorVenda,
                             };
                            
                            listaVendas.Add(venda);

                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Venda realizada com Sucesso!!!");
                            Console.WriteLine("------------------------------");

                            MenuVenda.TelaVenda();
                        }
                        else
                        {
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("código não corresponde ao produto!");
                            Console.WriteLine("-----------------------");
                            MenuVenda.TelaVenda();
                        }
                    }
                    else
                    {
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Produto não encontrado!");
                        Console.WriteLine("-----------------------");
                        MenuVenda.TelaVenda();
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("CPF não corresponde ao cliente!");
                    Console.WriteLine("-----------------------");
                    MenuVenda.TelaVenda();
                }
            }
            else
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Cliente não encontrado!");
                Console.WriteLine("-----------------------");
                MenuVenda.TelaVenda();
            }
        }
        public static void ConsultarPedidos()
        {
            if (listaVendas == null)
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Não há pedidos");
                Console.WriteLine("--------------");
                Console.ReadLine();
                MenuVenda.TelaVenda();
            }
            else
            {
                Console.WriteLine("Lista de pedidos: ");
                Console.WriteLine("");
                foreach (var venda in listaVendas)
                {
                    Console.WriteLine("ID do pedido: " + venda.Id + " | Nome do cliente: " + venda.Cliente.Nome + " | CPF: " + venda.Cliente.Cpf + " | Produto: " + venda.Produto.Nome + " | Valor do pedido: R$" + venda.ValorVenda);
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                }
                Console.ReadLine();
                MenuVenda.TelaVenda();
            }
        }

        public static void CancelarPedido()
        {
            Console.WriteLine("Informe o ID do pedido que deseja remover: ");
            string id = Console.ReadLine();

            List<Venda> novaListaPedidos = new List<Venda>();

            foreach (var venda in listaVendas)
            {
                if (id != venda.Id)
                {
                    novaListaPedidos.Add(venda);
                }
            }

            listaVendas = novaListaPedidos;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Cliente removido com sucesso!");
            Console.WriteLine("-----------------------------");

            MenuVenda.TelaVenda();
        }
    }
    }
