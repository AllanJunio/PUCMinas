using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // biblioteca para manipular arquivo
namespace maniparquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            //Abrir o arquivo 
            // Se o arquivo não existir será criado na pasta do projeto dentro de debug ..\maniparquivo\maniparquivo\bin\Debug
             StreamWriter valor = new StreamWriter("arquivo1.txt", true,
            Encoding.ASCII);
            //Loop para implementação dos numeros no TXT. 
            for (i = 0; i < 10; i++)
            {
                valor.Write(i);
            }
            //Fecha o arquivo 
            valor.Close();
            Console.WriteLine("Parabéns, agora mais um arquivo!");
            Console.Write("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);

            //Lendo o arquivo 
            StreamReader tr = new
            StreamReader(@"C:\temp\doc.txt");
            Console.WriteLine(tr.ReadToEnd()); //lê o arquivo até o fim
            Console.WriteLine(tr.ReadLine()); //lê apenas uma linha do arquivo

            tr.Close(); // fecha o arquivo
            Console.Write("Fim do programa...");
            Console.ReadKey();
        }
    }
}