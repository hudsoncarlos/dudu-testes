using System.Collections.Generic;

namespace LojaVirtual.dominio
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; set; }

        public CarrinhoDeCompras()
        {
            if (Produtos == null)
                Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}
