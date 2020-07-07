using System;
using System.Collections.Generic;
using System.Text;

namespace SomaFatorial
{
    public class SomaDigitosFatorial
    {
        private Int64 fatorial;
        private Int64 soma;

        public Int64 somaDigitos(Int64 n)
        {
            this.soma = 0;

            while (n != 0)
            {
                soma += n % 10;
                n /= 10;
            }

            return soma;
        }

        public Int64 calculaFatorial(Int64 n)
        {
            this.fatorial = 0;

            if (n <= 5)
            {
                for (fatorial = 1; n > 1; n = n - 1)
                {
                    fatorial = fatorial * n;
                }
            }
            else
            {
                Int64 temp = 120;
                for (int num = 6; num <= n; num++)
                {
                    fatorial = num * temp;
                    temp = fatorial;
                }
            }
            return fatorial;
        }

        public Int64 getSomaFatorial(Int64 n)
        {
            Int64 fatorial = calculaFatorial(n);
            return somaDigitos(fatorial);
        }
    }
}
