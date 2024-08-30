using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace readwriteapp
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter wr = new StreamWriter(@"C:\temp\doc.txt", true);

            string input = "";
            Console.WriteLine("Digite várias linhas de texto. Para sair, digite 'sair':");

            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "sair")
                {
                    break;
                }

                wr.WriteLine(input);
            }

            wr.Close();

            
            StreamReader rd = new StreamReader(@"C:\temp\doc.txt");
            Console.WriteLine("\nConteúdo do arquivo:");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();

            Console.Write("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}
