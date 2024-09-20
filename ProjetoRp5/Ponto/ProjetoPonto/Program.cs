namespace ProjetoPonto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do main...");
            ponto p1 = new ponto("P1:", 0.5, 5.8);
            p1.setDescricao("10");
            p1.imprimirCoordenadas();
            p1.incrementarCoordenadas(5, 2);
            p1.zerarCoordenadas();
            p1.imprimirCoordenadas();
            p1.incrementarCoordenadas(5, 2);
            p1.zerarCoordenadas();
            p1.imprimirCoordenadas();
            p1.toString();


            ponto p2 = new ponto("P2");
              p2.setDescricao("P2");
              p2.setX(25.6);
              p2.imprimirCoordenadas();
              p2.incrementarCoordenadas(6, 9);
              p2.imprimirCoordenadas();
              p2.incrementarCoordenadas(5, 2);
              p2.imprimirCoordenadas();
              p2.zerarCoordenadas();
              p2.toString();


            ponto p3 = new ponto("P3");
            p3.setDescricao("P3!!!!!");
            p3.imprimirCoordenadas();
            p3.incrementarCoordenadas(6, 9);
            p3.imprimirCoordenadas();
            p3.incrementarCoordenadas(5, 2);
            p3.imprimirCoordenadas();
            p3.zerarCoordenadas();
            p3.toString();
            Console.WriteLine("Fim do main...");
        }
        }
    }

