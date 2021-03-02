namespace LojaVirtual.dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Produto(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
