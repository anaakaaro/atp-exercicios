//Escrever os n termos Fibonacci, sendo n um valor lido:
//1, 1, 2, 3, 5, 8, 13, 21, ...

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());

        int a = 1;
        int b = 1;
        int t;

        Console.Write ($"{a}, {b}, ");

        for(int i = 3; i <= n; i++)
        {
            t = a + b;
            Console.Write($"{t}, ");

            a = b;
            b = t;
        }
    }
}