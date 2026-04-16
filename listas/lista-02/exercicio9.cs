using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro positivo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero <= 1)
        {
            Console.WriteLine("Não é primo");
            return;
        }

        bool ehPrimo = true;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
                break;
            }
        }

        if (ehPrimo)
        {
            Console.WriteLine("O número é primo");
        }
        else
        {
            Console.WriteLine("O número não é primo");
        }
    }
}