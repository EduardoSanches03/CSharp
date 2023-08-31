using System;
using TesteVenda;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new();
        cliente.Nome = "Eduardo";
        cliente.Idade = "19";
        cliente.Cpf = "1";

        ClienteController.listaClientes.Add(cliente);

        Produto produto = new();
        produto.Codigo = Config.GerarIDAleatorio();
        produto.Nome = "Teclado";
        produto.Valor = 85;

        ProdutoController.listaProdutos.Add(produto);

        Menu.TelaMenu();
    }

}
