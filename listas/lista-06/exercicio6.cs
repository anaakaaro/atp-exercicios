//Identificar se um número natural é primo ou não.

using System;

class Program
{
    static void Main()
    {
        Console.Write(EhPrimo(2));
    }

    static bool EhPrimo(int numero)
    {
        bool ehPrimo = true;

        if (numero <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
                break;
            }
        }

        return ehPrimo;
    }
}