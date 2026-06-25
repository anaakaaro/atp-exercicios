//Construa uma função recursiva que calcule o enésimo termo Fibonacci

using System;

class Program
{
    static void Main()
    {
        Console.Write(Fibonacci(5));
    }

    static int Fibonacci(int posicao)
    {
        if(posicao == 0) return 0;
        if(posicao == 1) return 1;

        return Fibonacci(posicao - 1) + Fibonacci(posicao - 2);

    }
}