//Calcular o maior entre dois valores reais.

using System;

class Program
{
    static void Main()
    {
        Console.Write(MaiorDeDois(600,50));
    }

    static double MaiorDeDois(double a, double b)
    {
        double maior;

        if(a > b) maior = a;
        else maior = b;

        return maior;
    }
}