using ConverterAlgarismoRomanoUsandoDPFactory.Service;
using NUnit.Framework;

namespace NUnitTestLivroTDDTesteDesignNoMundoReal.TesteConversorNumeroRomano
{
    [TestFixture]
    public class TestandoConversorDeNumeroRomano
    {
        [Test]
        public void DeveEntederOSimboloI() => Assert.AreEqual(1, new ConversorDeNumeroRomano().Converte("I"));

        //[Test]
        //public void DeveEntenderOSimboloDeUmAlgarismo()
        //{
        //    ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();
        //    int result = conversor.Converte("I");
        //    Assert.AreEqual(1, result);
        //}

        //[Test]
        //public void DeveEntenderOsSimbolosQueSeSoman()
        //{
        //    ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();
        //    int result = conversor.Converte("VI");
        //    Assert.AreEqual(6, result);
        //}

        //[Test]
        //public void DeveEntenderOsSimbolosQueSeSubtraen()
        //{
        //    ConversorDeNumeroRomano conversor = new ConversorDeNumeroRomano();
        //    int result = conversor.Converte("IV");
        //    Assert.AreEqual(4, result);
        //}
    }
}
