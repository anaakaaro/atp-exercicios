//Construa uma função recursiva que receba um vetor de reais e escreva todos os seus elementos, do
//primeiro ao último.

using System;
class Program
{
    static void Main()
    {
        double[] vetor = {5.3, 9.8, 5.6, 4.1};
        EscreveElementosVetor(vetor,0);
    }

    static void EscreveElementosVetor(double[] vetor, int i)
    {
        if(i == vetor.Length) return;

        Console.WriteLine(vetor[i]);

        EscreveElementosVetor(vetor, i+1);
    }
}