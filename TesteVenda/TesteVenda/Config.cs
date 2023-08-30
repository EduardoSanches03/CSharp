using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteVenda
{
    internal class Config
    {
        public static string GerarIDAleatorio()
        {
            Random random = new Random();

            int numeroAleatorio = random.Next(1000);

            Guid guid = Guid.NewGuid();
            string idAleatorio = guid.ToString("N");

            return $"{numeroAleatorio:D6}-{idAleatorio}";
        }
    }
}
