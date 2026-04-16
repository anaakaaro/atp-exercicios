//Escrever os n termos da sequência abaixo, sendo n um valor lido - 1, 5, 3, 8, 5, 11, 7, 14, ...

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sequência");
        int x = 1;

        Console.Write("Digite a quantidade de termos: ");
        int termos = int.Parse(Console.ReadLine());
        int a = 1;
        int b = 5;

        for(int i = 1; i <= termos/2; i++)
        {
            Console.Write(a + ", " + b + ", ");
            a += 2;
            b += 3;
        }
        
    }
}