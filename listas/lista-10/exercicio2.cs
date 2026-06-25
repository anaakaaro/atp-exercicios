//Construa uma função recursiva que receba um vetor de reais e escreva todos os seus elementos em
//ordem inversa, isto é, do último ao primeiro.

using System;

class Program
{
    static void Main()
    {
        double[] vetor = {5.3, 9.8, 5.6, 4.1};
        ImprimeVetorInverso(vetor, vetor.Length-1);
    }

    static void ImprimeVetorInverso(double[] vetor, int i)
    {
        if(i == -1) return;

        Console.WriteLine(vetor[i]);

        ImprimeVetorInverso(vetor, i - 1);
    }
}