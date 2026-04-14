//Ler 10 números reais. Ao final, informar o maior e o menor valor lido.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor: ");
        double x = double.Parse(Console.ReadLine());
        double maior = x;
        double menor = x;

        for(int i = 1; i <= 10; i++)
        {
            Console.Write("Digite o valor: ");
            x = double.Parse(Console.ReadLine());

            if(x > maior)
            {
                maior = x;
            }

            if(x < menor)
            {
                menor = x;
            }
        }
        Console.Write($"Maior número = {maior} e o menor número = {menor}");
    }
}