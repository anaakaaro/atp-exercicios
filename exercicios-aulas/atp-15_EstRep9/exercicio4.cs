//Calcule a soma alternada, conforme abaixo:
//Soma = 1 - 2 + 3 - 4 + 5 – 6 + ...
//até N, sendo N um valor lido.

using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        
        Console.WriteLine("Digite o valor de N: ");
        int n = int.Parse(Console.ReadLine());

        for ( int i = 1; i <= n; i++)
        {
            if(i % 2 != 0)
            {
                soma += i;
            }

            if(i % 2 == 0)
            {
                soma -= i;
            }
        }

        Console.WriteLine($"Resultado da soma: {soma}");

    }
}
