//Verificar ser um ano bissexto ou não

using System;

class Program
{
    static void Main()
    {
        int ano = 2004;

        if (EhBissexto(ano))
        {
            Console.WriteLine("O ano é bissexto.");
        } else
        {
            Console.WriteLine("O ano não é bissexto.");
        }
    }

    static bool EhBissexto(int ano)
    {
        bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        
        return ehBissexto;
    }
}