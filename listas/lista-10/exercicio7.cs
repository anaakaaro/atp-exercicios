// Construa uma função recursiva que calcule o somatório de 1 até N

using System;

class Program
{
    static void Main()
    {
        Console.Write(Somatorio(4));
    }

    static int Somatorio(int n)
    {
        if(n == 1) return 1;

        return n + Somatorio(n - 1);
    }
}