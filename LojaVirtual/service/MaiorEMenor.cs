using LojaVirtual.dominio;

namespace LojaVirtual.service
{
    public class MaiorEMenor
    {
        public Produto Menor { get; set; }
        public Produto Maior { get; set; }

        public void Encontra(CarrinhoDeCompras carrinho)
        {
            foreach (Produto produto in carrinho.Produtos)
            {
                if (Menor == null || produto.Valor < Menor.Valor)
                    Menor = produto;
                if (Maior == null || produto.Valor > Maior.Valor)
                    Maior = produto;
            }
        }
    }
}
