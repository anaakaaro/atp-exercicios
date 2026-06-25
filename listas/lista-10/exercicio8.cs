// Construa uma função recursiva que conte o número de dígitos presente em um número natural.

using System;

class Program
{
    static void Main()
    {
        Console.Write(Digitos(50369));
    }

    static int Digitos(int n)
    {
        if(n < 10) return 1;

        return 1 + Digitos(n / 10);
    }
}