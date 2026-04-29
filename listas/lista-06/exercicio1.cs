//Calcular o maior entre dois valores reais.
using System;

class Program
{
    static void Main()
    {
        Console.Write(MaiorDeDois(100.60, 4506.9));
    }

    static double MaiorDeDois(double x, double y)
    {
        double maior;

        if(x > y)
        {
            maior = x;
        }
        else
        {
            maior = y;
        }

        return maior;
    }
}