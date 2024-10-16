using System.Formats.Tar;

namespace ProjetoFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInício main - Fila Interativa");
            TADFila fila = new TADFila(1, "Fila de Teste", 10);  // Criando uma fila com capacidade.

            bool executar = true;
            while (executar)
            {
                try
                {
                    Console.WriteLine("\nEscolha uma opção:");
                    Console.WriteLine("1 - Incluir na Fila");
                    Console.WriteLine("2 - Retirar da Fila");
                    Console.WriteLine("3 - Imprimir Fila");
                    Console.WriteLine("4 - Sair");
                    Console.Write("Opção: ");
                    string opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite o valor para incluir na fila: ");
                            if (int.TryParse(Console.ReadLine(), out int valor))
                            {
                                fila.IncluirNaFila(valor);
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido! Por favor, insira um número inteiro.");
                            }
                            break;

                        case "2":
                            int retirado = fila.RetirarDaFila();
                            if (retirado != -1)
                            {
                                Console.WriteLine($"Valor retirado: {retirado}");
                            }
                            break;

                        case "3":
                            fila.ImprimirFila();
                            break;

                        case "4":
                            Console.WriteLine("Fim do programa.");
                            executar = false;
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Tente novamente.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }

            Console.WriteLine("\nFim main");
        }
    }
}
