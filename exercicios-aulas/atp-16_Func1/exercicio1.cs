//Implemente uma função para escrever o resultado da soma de 2 números

using System;

class Program
{
    static void Main()
    {
        double soma = Soma(5,6);
        Console.WriteLine($"Resultado da soma = {soma}");
    }

    static double Soma(double x, double y)
    {
        double soma;
        soma = x + y;

        return soma;
    }
}