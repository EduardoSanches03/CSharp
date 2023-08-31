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

            const string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int tamanhoMaximo = 6;

            char[] idAleatorio = new char[tamanhoMaximo];

            for (int i = 0; i < tamanhoMaximo; i++)
            {
                idAleatorio[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }

            return new string(idAleatorio);
        }

    }
}
