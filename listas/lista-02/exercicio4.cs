//Escrever os números inteiros de 1 até 10 utilizando while, do while e for.
using System;

class Program
{
    static void Main()
    {
        int contador = 1;
        int contador2 = 1;

        Console.WriteLine("While - Teste do início");
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador ++;
        }

        Console.WriteLine("Do While - Teste no final");
        do
        {
            Console.WriteLine(contador2);
            contador2 ++;
        } while (contador2 <= 10);

        Console.WriteLine("For - Variável de controle");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

    }
}