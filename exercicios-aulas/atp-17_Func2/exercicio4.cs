//Ler anos até que seja lido zero.
//Informar quantos são bissextos e quantos não são.

using System;

class Program
{
    static void Main()
    {
        int ano;
        int bissextos = 0;
        int contagem = 0;

        do
        {
            Console.Write($"Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            

            if(ano != 0)
            {
                contagem++;

                if (EhBissexto(ano))
                {
                    bissextos++;
                }
            }
            
        } while(ano != 0);
            
       
        if(bissextos == 1)
        {
            Console.WriteLine($"Dos {contagem} anos que você digitou {bissextos} é bissexto.");
        }
        else
        {
            Console.WriteLine($"Dos {contagem} anos que você digitou {bissextos} são bissextos.");
        }
        
    }

    static bool EhBissexto(int ano)
    {
        bool ehBissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
        
        return ehBissexto;
    }
}