//Escrever o n primeiros números pares, sendo n um valor lido
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o número de números pares: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            Console.Write($"{i * 2} ");

            if (i < x){
                Console.Write(", ");
            }
        }

    }
}