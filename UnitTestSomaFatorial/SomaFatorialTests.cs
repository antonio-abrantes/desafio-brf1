using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomaFatorial;

namespace UnitTestSomaFatorial
{
    [TestClass]
    public class SomaFatorialTests
    {
        [TestMethod]
        public void TestCalculaFatorial()
        {
            int n = 6;

            SomaDigitosFatorial sf = new SomaDigitosFatorial();

            Console.WriteLine("Calcula fatorial.: {0}", sf.calculaFatorial(n));

        }

        [TestMethod]
        public void TestSomaDigito()
        {
            int n = 123;

            SomaDigitosFatorial sf = new SomaDigitosFatorial();

            Console.WriteLine("Calcula fatorial.: {0}", sf.somaDigitos(n));

        }

        [TestMethod]
        public void TestSomaFatorial()
        {
            int n = 20;

            SomaDigitosFatorial sf = new SomaDigitosFatorial();

            Console.WriteLine("Calcula fatorial.: {0}", sf.getSomaFatorial(n));

        }
    }
}
