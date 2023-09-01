namespace TesteAPI.Models
{
    public class FreshTea
    {
        private string _nome;
        private Ingredientes _ingredientes;
        private double _valor;

        public FreshTea()
        {
            _nome = string.Empty;
        }
        public FreshTea(string nome, Ingredientes ingredientes, double valor)
        {
            _nome = nome;
            _ingredientes = ingredientes;
            _valor = valor;
        }
    }

    
}