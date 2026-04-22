//Escrever os n termos Fibonacci, sendo n um valo lido - 1, 1, 2, 3, 5, 8, 13, 21, ...
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Fibonacci");

        int a = 1;
        int b = 1;
        int t, n;

        do
        {
            Console.Write("Digite a quantidade de termos: ");
            n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.Write("Mínimo 2 termos.");
            }
        }while(n < 2);

        Console.Write(a + ", " + b);

        for(int i = 3; i <= n; i++)
        {
            t = a + b;
            Console.Write(t + ", ");
            a = b;
            b = t;
        }
    }
}