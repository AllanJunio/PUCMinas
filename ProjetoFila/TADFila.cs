using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFila
{
    internal class TADFila
    {
        private Queue<int> fila;  // Fila para armazenar os elementos.
        public int Codigo { get; private set; }  // Código da fila.
        public string Descricao { get; private set; }  // Descrição da fila.
        public int Capacidade { get; private set; }  // Capacidade máxima da fila.

        public TADFila(int codigo, string descricao, int capacidade)
        {
            Codigo = codigo;
            Descricao = descricao;
            Capacidade = capacidade;
            fila = new Queue<int>();  // Inicializa a fila.
        }

        public void IncluirNaFila(int k)
        {
            if (fila.Count >= Capacidade)
            {
                Console.WriteLine("Fila cheia! Não é possível adicionar mais elementos.");
            }
            else
            {
                fila.Enqueue(k);  // Adiciona o elemento ao final da fila.
                Console.WriteLine($"Valor {k} incluído na fila.");
            }
        }

        public int RetirarDaFila()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("Fila vazia! Não há elementos para retirar.");
                return -1;  // Retorna -1 para indicar erro.
            }

            return fila.Dequeue();  // Remove e retorna o elemento do início da fila.
        }

        public void ImprimirFila()
        {
            if (fila.Count == 0)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("Elementos na fila:");
            int contador = 0;
            foreach (int elemento in fila)
            {
                string posicao = contador == 0 ? "Início" :
                                 (contador == fila.Count - 1 ? "Final" : "");
                Console.WriteLine($" {elemento} {posicao}");
                contador++;
            }
        }
    }

}