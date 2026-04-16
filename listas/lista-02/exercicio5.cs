//Escrever os números inteiros de 10 até 1 utilizando while, do while e for.
using System;

class Program
{
    static void Main()
    {
        int contador = 10;
        int contador2 = 10;

        Console.WriteLine("While - Teste do início");
        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador --;
        }

        Console.WriteLine("Do While - Teste no final");
        do
        {
            Console.WriteLine(contador2);
            contador2 --;
        } while (contador2 >= 1);

        Console.WriteLine("For - Variável de controle");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

    }
}