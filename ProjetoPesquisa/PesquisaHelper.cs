public class PesquisaHelper
{

    // Retorna a posição da chave no vetor

    public static int pesquisaSimples(int[] v, int n, int chave)
    {
        int contador = 0;
        for (int i = 0; i < n; i++)
        {
            if (v[i] == chave)
            {
                contador += ;
                return 1;
                break;
            }
            else
            {
                return -1;
            }
        }

        Console.WriteLine("o numero de vezes que o vetor teve suas posições consultadas foi de: " + contador);

    }

    public static int pesquisaBinaria(int[] x, int n, int k)
    {
        int i = 0, j = n - 1, pivo = 0;
        do
        {
            pivo = (i + j) / 2;
            if (k > x[pivo])
                i = pivo + 1;
            else
                j = pivo - 1;
        }
        while ((x[pivo] != k) && (i <= j));
        if (x[pivo] == k)
            return pivo;
        return -1;
    }
}