using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPilha
{
    internal class TADPilha (int n)
    {
        string descricao = "";
        int capacidade = 0;
        List<int> elementos;  // Lista para armazenar os elementos.
        
        public int pop()
        {
       
            if (elementos.Count == 0)
            {
                Console.WriteLine("Pilha vazia! Não há nada para desempilhar.");
                return -1;
            }

            int elemento = elementos[^1];  // Acessa o último elemento da lista.
            elementos.RemoveAt(elementos.Count - 1);  // Remove o último elemento.
            return elemento;
            
        }
        public void push(int k)
            
        { // empilha o elemento k 
            elementos = new List<int>();  // Inicializa a lista para evitar NullReferenceException
            elementos.Add(k);  // Adiciona o elemento no final da lista.
            Console.WriteLine($"Valor {k} empilhado.");

        }
        public void imprimirPilha()
        { // imprime todo o conteúdo da pilha. É obrigatório indicar 
          // qual é o elemento da base da pilha. 
            if (elementos.Count == 0)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }

            Console.WriteLine("Elementos na pilha:");
            for (int i = elementos.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($" {elementos[i]}");
            }
        }

    }
}
