//Faça uma função que leia sucessivos números inteiros fornecidos pelo usuário e só pare quando for
//digitado o valor 0. A função deve retornar o percentual de números ímpares lidos.

using System;

class Program
{
    static void Main()
    {
        double resultado = PercentImpares();
        Console.WriteLine($"Percentual de ímpares: {resultado}%");
    }

    static double PercentImpares()
    {
        int impares = 0;
        int n, total = 0;
        double percentImpares;
        
        do
        {
            Console.Write("Digite um número [0 p/ sair]: ");
            n = int.Parse(Console.ReadLine());
            

            if(n != 0)
            {
                total++;

                if (n % 2 != 0)
                {
                    impares++;
                }
            }
            

        } while(n != 0);

        percentImpares = (double)impares / total * 100;

        return percentImpares;
    }
}