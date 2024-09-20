using System;
namespace ProjetoRecursividade{
    public class recursividadeHelper : IfcRecursividade
    {
        // Implementação do cálculo de fatorial (recursivo)
        public long getFatorial(long n)
        {
            if (n <= 1)
                return 1;
            return n * getFatorial(n - 1);
        }

        // Implementação do cálculo de fatorial (iterativo)
        public long getFatorial(long n, bool flag)
        {
            long result = 1;
            for (long i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Implementação do cálculo de Fibonacci (recursivo)
        public long getFibonacci(long n) {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return getFibonacci(n - 2) + getFibonacci(n - 1);
            }
        }

        // Implementação do cálculo de Fibonacci (iterativo)
        public long getFibonacci(long n, bool flag)
        {
            if (n <= 1)
                return 0;
            if (n == 2)
                return 1;

            long a = 0, b = 1, c = 0;

            for (long i = 3; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
