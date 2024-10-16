using modelo;
using System.Collections;
using controle;

namespace visao
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do Main");
            PlanoCartesianoDAO objetoPc1 = new PlanoCartesianoDAO();

            // Obter e exibir elementos hardcoded (como strings)
            ArrayList lista = objetoPc1.obterTodos();
            Console.WriteLine("Imprime o código hard code");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }

            // Obter e exibir linhas do arquivo como strings
            lista = objetoPc1.obterTodos(1);
            Console.WriteLine("Imprime as linhas do arquivo");
            foreach (string objeto in lista)
            {
                Console.WriteLine(objeto);
            }

            // Obter e exibir objetos do tipo PontoVO do arquivo
            lista = objetoPc1.obterTodos(1, true);
            Console.WriteLine("Imprime todos os pontos do arquivo");
            foreach (PontoVO ponto in lista)
            {
                Console.WriteLine(ponto);
            }

            // Testar criação de objetos PontoVO diretamente no Main
            Console.WriteLine("\nTestando criação de objetos PontoVO:");
            PontoVO ponto1 = new PontoVO(1, 2, "Ponto A", 12.5, 8.3);
            PontoVO ponto2 = new PontoVO(2, 1, "Ponto B", 5.0, 3.5);

            Console.WriteLine(ponto1);
            Console.WriteLine(ponto2);

            // Verificar igualdade entre dois objetos PontoVO
            Console.WriteLine($"\nOs pontos 1 e 2 são iguais? {ponto1.Equals(ponto2)}");

            // Obter e exibir pontos do semiplano ímpar
            PlanoCartesianoController objetoController = new PlanoCartesianoController();
            lista = objetoController.selecionarPontosSemiPlanoImpar();
            Console.WriteLine("Imprime todos os pontos do semi plano ímpar");
            foreach (PontoVO ponto in lista)
            {
                Console.WriteLine(ponto);
            }

                   // Exibindo pontos no semiplano direito (X > 0)
            PlanoCartesianoController controller = new PlanoCartesianoController();
            ArrayList pontosDireito = controller.selecionarPontosPorSemiplano(1);
            Console.WriteLine("Pontos no semiplano direito:");
            foreach (PontoVO ponto in pontosDireito)
            {
                Console.WriteLine(ponto);
            }

            // Exibindo pontos do semiplano par (X * Y < 0)
            ArrayList pontosPar = controller.selecionarPontosSemiPlanoPar();
            Console.WriteLine("Pontos no semiplano par:");
            foreach (PontoVO ponto in pontosPar)

            {
                Console.WriteLine(ponto);
            }
            Console.WriteLine("Fim do Main");
        }
    }
}
