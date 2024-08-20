namespace projetoPratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, contador = 0, soma = 0;
            double media = 0;
            int opcao;
            int maior = int.MinValue, menor = int.MaxValue;

            do
            {
                Console.WriteLine("Menu de opções:");
                Console.WriteLine("1 - Inserir um número");
                Console.WriteLine("2 - Verificar quantidade de valores digitados");
                Console.WriteLine("3 - Verificar o maior valor inserido");
                Console.WriteLine("4 - Verificar o menor valor inserido");
                Console.WriteLine("5 - Verificar a média dos valores inseridos");
                Console.WriteLine("6 - Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite um número igual ou maior que 0: ");
                        n = int.Parse(Console.ReadLine());
                        soma += n;
                        contador++;

                        if (n > maior)
                            maior = n;
                        if (n < menor)
                            menor = n;

                        break;

                    case 2:
                        Console.WriteLine($"Quantidade de valores digitados: {contador}");
                        break;

                    case 3:
                        Console.WriteLine($"Maior valor inserido: {maior}");
                        break;

                    case 4:
                        Console.WriteLine($"Menor valor inserido: {menor}");
                        break;

                    case 5:
                        if (contador > 0)
                        {
                            media = (double)soma / contador;
                            Console.WriteLine($"Média dos valores inseridos: {media}");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum valor foi inserido ainda.");
                        }
                        break;

                    case 6:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

            } while (opcao != 6);

            Console.WriteLine("Digite algo para continuar...");
            Console.ReadKey();
        }
    }
}
