using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculadora;

namespace Testes
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestSoma()
        {
            CalculadoraDotNet c = new CalculadoraDotNet();
            int resultado = c.Soma(3, 4);
            Assert.AreEqual(7, resultado);
        }
    }
}
