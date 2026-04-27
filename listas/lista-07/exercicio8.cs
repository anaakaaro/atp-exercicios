//Construa uma função que receba dois inteiros positivos e verifique se os dois números têm a mesma
//quantidade de divisores.

using System;

class Program
{
    static void Main()
    {
        Console.Write(MesmaQuantDivisores(2,3));
    }

    static bool MesmaQuantDivisores(int a, int b)
    {
        int divisoresA = 0, divisoresB = 0;

        for(int i = 1; i <= a; i++)
        {
            if(a % i == 0)
            {
                divisoresA++;
            }
        }

        for(int i = 1; i <= b; i++)
        {
            if(b % i == 0)
            {
                divisoresB++;
            }
        }

        return divisoresA == divisoresB;
    }
}

