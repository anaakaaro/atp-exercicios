//Calcular o fatorial de um número natural.


using System;

class Program
{
    static void Main()
    {
        Console.Write(Fatorial(5));
    }

    static int Fatorial(int x)
    {
        int fatorial = 1;

        if(x < 0) {
            throw new ArgumentException("Número deve ser não negativo");
        }

        for(int i = 1; i <= x; i++)
        {
            fatorial *= i;
        }

        return fatorial;
    }
}