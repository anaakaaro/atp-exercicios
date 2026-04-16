//Calcular a soma de dez números lidos. Em seguida, escrever o resultado.

using System;

class Program
{
    static void Main()
    {
        double numero, soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            soma += numero;
        }
        Console.WriteLine($"Resultado da soma dos números digitados: {soma}");
    }
}