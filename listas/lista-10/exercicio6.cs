// Construa uma função recursiva que receba um vetor de reais e escreva apenas os valores positivos.

using System;

class Program
{
    static void Main()
    {
        double[] vetor = {-5.3, 9.8, -5.6, 4.1};
        EscreveValoresPositivos(vetor, 0);
    }

    static void EscreveValoresPositivos(double[] vetor, int i)
    {
        if(i == vetor.Length) return;

        if(vetor[i] > 0)
        {
            Console.WriteLine(vetor[i]);
        }

        EscreveValoresPositivos(vetor, i +1);
    }
}