//Ler 10 anos e informar quantos são bissextos.

using System;

class Program
{
    static void Main()
    {
        int ano;
        int bissextos = 0;

        for(int i = 1; i <= 10; i++)
        {
            Console.Write($"Digite {i}º ano: ");
            ano = int.Parse(Console.ReadLine());

            if (EhBissexto(ano))
            {
                bissextos++;
            }
        }

        Console.WriteLine($"Dos 10 anos que você digitou {bissextos} são bissextos.");
    }

    static bool EhBissexto(int ano)
    {
        bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        
        return ehBissexto;
    }
}