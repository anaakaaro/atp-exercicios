//Ler números naturais até que a flag, um valor negativo, seja lido. Ao
//final, informar o maior e o menor valor lido.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor: ");
        double x = double.Parse(Console.ReadLine());
        double maior = x;
        double menor = x;

        while (x > 0)
        {
            if(x > maior)
            {
                maior = x;
            }

            if(x < menor)
            {
                menor = x;
            }

            Console.Write("Digite o valor: ");
            x = double.Parse(Console.ReadLine());
        }

        if(maior >= 0)
        {
            Console.WriteLine($"Maior número = {maior}");
            Console.WriteLine($"Menor número = {menor}");
        }
    }
}