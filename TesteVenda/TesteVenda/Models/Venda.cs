using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Venda
    {
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public string Id {  get; set; }
        public int Quantidade { get; set; }
        public double ValorVenda { get; set; }

        public Venda(Cliente cliente, Produto produto, int quantidade, double valorVenda)
        {
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            ValorVenda = valorVenda;
        }

    }
}
