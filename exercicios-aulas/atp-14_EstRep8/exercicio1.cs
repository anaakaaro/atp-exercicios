//Calcular a soma de um conjunto de números
//naturais lidos. Flag: valor igual a zero

using System;

class Program
{
    static void Main()
    {
        double soma = 0;

        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        while(numero != 0)
        {
            soma += numero;

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Resultado da soma: {soma}");
    }
}