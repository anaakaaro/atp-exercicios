//Escrever os n termos da sequência abaixo, sendo n um valor lido - 1, 4, 7, 10, 13, ...

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sequência");
        int x = 1;

        Console.Write("Digite a quantidade de termos: ");
        int termos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= termos; i++)
        {
            Console.WriteLine(x);
            x += 3;
        }
    }
}