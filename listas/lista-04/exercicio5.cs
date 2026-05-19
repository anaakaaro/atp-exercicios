//Calcular a soma dos n primeiros números pares, sendo n um valor lido.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());

        int soma = 0;

        for(int i = 1; i <= n; i++)
        {
            Console.Write(i * 2 + " ");
            soma += i*2;
        }

        Console.Write($"\nResultado da soma: {soma}");
    }
}