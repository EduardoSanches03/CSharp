namespace TesteAPI.Models
{
    public class Ingredientes
    {
        private string _nome;
        private int _quantidade;

        public Ingredientes() 
        {
            _nome = string.Empty;
            _quantidade = 0;
        }
        public Ingredientes(string nome, int quantidade)
        {
            _nome = nome;
            _quantidade = quantidade;
        }
    }
}
