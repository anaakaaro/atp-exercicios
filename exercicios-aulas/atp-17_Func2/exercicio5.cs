//Ler um ano e informar qual o próximo ano bissexto.
using System;

class Program
{
    static void Main()
    {
        int ano;

        Console.Write("Digite um ano: ");
        ano = int.Parse(Console.ReadLine());

        int proximo = ano++;

        while (!EhBissexto(proximo))
        {
            proximo++;
        }

        Console.WriteLine($"Próximo ano bissexto: {proximo}");
    }

    static bool EhBissexto(int ano)
    {
        bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        
        return ehBissexto;
    }
}