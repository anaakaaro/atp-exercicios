//Identificar o maior dentre um conjunto de
//números naturais lidos. Flag: valor igual a zero

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());

        double maiorNumero = numero;

        while(numero != 0)
        {
            if(numero > maiorNumero)
            {
                maiorNumero = numero;
            }

            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Maior número lido: {maiorNumero}");

    }
}