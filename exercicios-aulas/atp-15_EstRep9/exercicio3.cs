//Verificar se um inteiro lido é um número primo ou não.

using System;

class Program
{
    static void Main()
    {
        int x;
        bool erro;

        do
        {
            Console.Write("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            erro = x < 1;

            if (erro)
            {
                Console.WriteLine("Digite um número válido.");
            }
        } while(erro);

         if (x == 1)
        {
            Console.WriteLine("O 1 não é primo.");
            return;
        }

        bool primo = true;
        int d = 2;

        while (primo && d * d <= x)
        {
            if(x % d == 0)
            {
                primo = false;
            }

            d++;
        }

        if (primo)
        {
            Console.WriteLine($"O {x} é primo.");
        }
        else
        {
            Console.WriteLine($"O {x} não é primo.");
        }
    }
}