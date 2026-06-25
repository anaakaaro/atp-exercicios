//Construa uma função recursiva que calcule e retorne o fatorial de N

using System;

class Program
{
    static void Main()
    {
        Console.Write(Fatorial(5));
    }

    static int Fatorial(int n)
    {
        if(n <= 1) return 1;

        return n * Fatorial(n - 1);
    }
}