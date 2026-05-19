//Escrever o n primeiros números pares, sendo n um valor lido.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n*2; i++)
        {
            if(i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}