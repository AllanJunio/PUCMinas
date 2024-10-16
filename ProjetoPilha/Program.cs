namespace ProjetoPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInício main");
            TADPilha pilha = new TADPilha(5);

            bool executar = true;
            while (executar)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Empilhar (Push)");
                Console.WriteLine("2 - Desempilhar (Pop)");
                Console.WriteLine("3 - Imprimir Pilha");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor para empilhar: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            pilha.push(valor);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case "2":
                        int desempilhado = pilha.pop();
                        if (desempilhado != -1)
                        {
                            Console.WriteLine($"Valor desempilhado: {desempilhado}");
                        }
                        break;

                    case "3":
                        pilha.imprimirPilha();
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
        }
    }
}
