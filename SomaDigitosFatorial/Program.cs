using System;
using SomaFatorial;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());

            SomaDigitosFatorial sf = new SomaDigitosFatorial();

            Console.WriteLine("Calcula fatorial.: {0}", sf.calculaFatorial(n));
            Console.WriteLine("Soma dos digitos.: {0}", sf.getSomaFatorial(n));

            Console.ReadKey();
        }
    }
}