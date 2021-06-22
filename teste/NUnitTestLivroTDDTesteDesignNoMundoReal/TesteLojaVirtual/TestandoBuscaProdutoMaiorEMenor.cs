using LojaVirtual.dominio;
using LojaVirtual.service;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestLivroTDDTesteDesignNoMundoReal.TesteLojaVirtual
{
    [TestFixture]
    public class TestandoBuscaProdutoMaiorEMenor
    {
        [Test]
        public void Validar_Instancia_modelos_Produto()
        {
            var prd = new Produto("Hudson", 2.5);
            Assert.IsNotNull(prd);

            Assert.AreEqual(prd.GetType(), typeof(Produto));
            Assert.AreEqual(prd.Id.GetType(), typeof(int));
            Assert.AreEqual(prd.Nome.GetType(), typeof(string));
            Assert.AreEqual(prd.Valor.GetType(), typeof(double));
        }

        [Test]
        public void Validar_Instancia_Modelo_CarrinhoDeCompras()
        {
            var cdc = new CarrinhoDeCompras();
            Assert.IsNotNull(cdc);

            Assert.AreEqual(cdc.GetType(), typeof(CarrinhoDeCompras));
            Assert.IsNotNull(cdc.Produtos);
            
            cdc.Adiciona(new Produto("Hudson", 5.1));
            Assert.IsTrue(cdc.Produtos.Count > 0);
        }

        [Test]
        public void Validar_Intancia_Modelo_MaiorMenor()
        {
            var mm = new MaiorEMenor();

        }

        [Test]
        public void OrdemDecrescente()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.0));
            carrinho.Adiciona(new Produto("Jogo de pratos", 70.0));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }

        [Test]
        public void ApenasUmProduto()
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));

            var algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Geladeira", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);
        }
    }
}
