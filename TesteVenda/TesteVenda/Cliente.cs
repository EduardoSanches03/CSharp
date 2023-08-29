using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Cliente
    {
        private String _nome;
        private String _idade;
        private String _cpf;


        public String Nome
        {
            get => _nome; set => _nome = value;
        }

        public String Idade
        {
            get => _idade; set => _idade = value;
        }
        public String Cpf
        {
            get => _cpf; set => _cpf = value;
        }
    }
}
