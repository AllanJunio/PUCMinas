namespace Rp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, opcao = 0;
            string valorB = "";
            figuraHelper figuraHelper = new figuraHelper();

            do
            {
                Console.WriteLine("\n-=- Menu de opções -=- ");
                Console.WriteLine("\n-=-Perímetro do círculo..............[1]");
                Console.WriteLine("\n-=- Perímetro do retângulo...........[2]");
                Console.WriteLine("\n-=- Perímetro do triângulo............[3]");
                Console.WriteLine("\n-=- Sair..............................[4]");
                Console.WriteLine("\n\n\n-=- Digite sua opção: ");
                valorB = Console.ReadLine();
                opcao = int.Parse(valorB);
                switch (opcao)
                {

                    case 1:
                        {
                            double raio = 5;
                            Console.WriteLine("\nCalcular perímetro do círculo! ");
                            double resultadoCirculo = figuraHelper.calcularPerimetro(raio);
                            Console.WriteLine(resultadoCirculo);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nCalcular perímetro do retângulo! ");
                            double x = 3;
                            double altura = 4;
                            double resultadoRetangulo = figuraHelper.calcularPerimetro(x, altura);
                            Console.WriteLine(resultadoRetangulo);
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("\nCalcular perímetro do triângulo! ");
                            double lado1 = 7;
                            double lado2 = 7;
                            double lado3 = 7;
                            double resultadoTriangulo = figuraHelper.calcularPerimetro(lado1, lado2, lado3);
                            Console.WriteLine(resultadoTriangulo);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nSair! ");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nNúmero digitado: OUTROS VALORES! ");
                            break;
                        }
                }
            } while (opcao != 4);

            Console.WriteLine("\nFim do programa ");
        }
    }
}
