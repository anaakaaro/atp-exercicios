//Calcular o fatorial de um número natural.

using System;

class Program
{
    static void Main()
    {
        Console.Write(Fatorial(13));
    }

    static int Fatorial(int n)
    {
        int fatorial = 1; 

        if(n < 0)
        {
            Console.WriteLine("Digite um número válido.");
        } 

        for(int i = 1; i <= n; i++)
        {
            Console.Write(i);
            fatorial *= i;

            if(i < n)
            {
                Console.Write(" x "  );
            } else Console.Write(" = ");
        }

        return fatorial;
    }
}