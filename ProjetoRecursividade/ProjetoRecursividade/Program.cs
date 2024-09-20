using System;

namespace ProjetoRecursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            recursividadeHelper helper = new recursividadeHelper();
            long n;

            // Menu interativo para cálculo de Fibonacci
            while (true)
            {
                Console.Write("Digite um valor de n (n >= 0) para calcular o enésimo termo da série de Fibonacci ou um valor negativo para sair: ");
                
                // Leitura do valor de n
                string input = Console.ReadLine();

                // Verifica se a entrada é nula
                if (input == null)
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue;
                }

                // Tenta converter a entrada para long
                if (!long.TryParse(input, out n))
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                    continue;
                }

                // Verifica se o valor é negativo
                if (n < 0)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }

                // Calculando o enésimo termo da série de Fibonacci usando a versão recursiva
                long fibonacciRecursivo = helper.getFibonacci(n);
                Console.WriteLine($"Fibonacci recursivo do termo {n} é: {fibonacciRecursivo}");

                // Calculando o enésimo termo da série de Fibonacci usando a versão iterativa
                long fibonacciIterativo = helper.getFibonacci(n, true);
                Console.WriteLine($"Fibonacci iterativo do termo {n} é: {fibonacciIterativo}");

                Console.WriteLine();
            }
        }
    }
}
