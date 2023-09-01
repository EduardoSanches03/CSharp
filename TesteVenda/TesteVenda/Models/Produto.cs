using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Produto
    {
        private string _codigo;
        private string _nome;
        private double _valor;

        public string Codigo
        {
            get => _codigo; set => _codigo = value;
        }
        public string Nome
        {
            get => _nome; set => _nome = value;
        }
        public double Valor
        {
            get => _valor; set => _valor = value;
        }
    }
}
