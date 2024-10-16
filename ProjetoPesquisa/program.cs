namespace ProjetoPesquisa

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Início do Main");

            int chave;
            int[] v = { 25, 48, 37, 12, 57, 86, 33, 92 };

            // Exibir o conteúdo do vetor
            Console.WriteLine("\nConteúdo do vetor: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }

            // Solicitar chave do usuário
            Console.WriteLine("\n\nDigite a chave a ser pesquisada no vetor: ");
            chave = int.Parse(Console.ReadLine());

            // Pesquisar chave no vetor
            int posicao = PesquisaHelper.pesquisaSimples(v, v.Length, chave);
            if (posicao >= 0)
            {
                Console.WriteLine("Chave foi encontrada na posição: " + posicao);
            }
            else
            {
                Console.WriteLine("Chave não foi encontrada");
            }

            Console.WriteLine("\n Fim do programa");
        }
    }