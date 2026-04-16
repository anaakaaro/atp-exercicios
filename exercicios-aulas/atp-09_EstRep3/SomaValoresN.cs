//Calcular e escrever a soma de n números lidos, sendo n também um valor lido.

using System;

class Program
{
    static void Main()
    {
        double numero, soma = 0;

        Console.Write("Digite a quantidade de números a serem lidos: ");
        int t = int.Parse(Console.ReadLine());

        for (int i = 1; i <= t; i++)
        {
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            soma += numero;
        }
        Console.WriteLine($"Resultado da soma dos números digitados: {soma}");
    }
}