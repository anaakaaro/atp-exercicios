//Calcular e escrever a soma de n números lidos, sendo n também um valor lido.
using System;

class Program
{
    static void Main()
    {
        int numero, soma = 0;

        Console.Write("Digite a quantidade de números: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        }

        Console.Write($"Resultado da soma dos {n} números: {soma}");
    }
}