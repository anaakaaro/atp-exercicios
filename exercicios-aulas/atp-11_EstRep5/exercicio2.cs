//Calcular a soma dos n primeiros números pares, sendo n um valor lido.

using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        Console.WriteLine("Digite o número de números pares: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            soma += i*2;
        }

        Console.WriteLine($"Resultado da soma: {soma}");
    }
}