using System;
using System.Collections.Generic;
using System.Text;

namespace bases
{
    class Pilha
    {
        private int[] vet; // vetor para armazenar os elementos da pilha
        private int topo; // indica a posição do topo

        public Pilha(int tam) // CONSTRUTOR
        {
            vet = new int[tam];
            topo = 0;
        }

        public void Empilhar(int x)
        {
            vet[topo] = x;
            topo++;
        }

        public int Desempilhar()
        {
            topo--;
            return (vet[topo]);
        }

        public bool Vazia()
        {
            return (topo == 0);
        }

        public bool Cheia()
        {
            return (topo == vet.Length);
        }

    }
}
