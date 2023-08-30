using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Venda
    {
        public Cliente Cliente { get; }
        public Produto Produto { get; }
        public int Quantidade { get; }

        public Venda(Cliente cliente, Produto produto, int quantidade)
        {
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
        }

        public double CalcularTotal()
        {
            return Produto.Valor * Quantidade;
        }
    }
}
