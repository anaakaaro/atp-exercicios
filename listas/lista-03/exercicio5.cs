//Calcular a soma de dez números lidos. Em seguida, escrever o resultado.

using System;

class Program
{
    static void Main()
    {
        int numero;
        int soma = 0;
        int[] numeros = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i+1} número: ");
            numeros[i] = int.Parse(Console.ReadLine());
            
            soma += numeros[i];
        }

        for (int i = 0; i < 10; i++)
        {
            Console.Write(numeros[i]);
            if(i < 9)
            {
                Console.Write(" + ");
            }
        }

        Console.Write($" = {soma}");


    }
}