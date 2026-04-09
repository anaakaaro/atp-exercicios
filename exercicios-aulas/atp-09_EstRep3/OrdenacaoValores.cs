//Ler três valores reais e ordená-los. Escrever os números na ordem crescente.
using System;

class Program
{
    static void Main()
    {
        double num1, num2, num3, menor, meio, maior;
        Console.WriteLine("Ordenação de valores");

        Console.Write("Digite o primeiro valor: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor: ");
        num3 = double.Parse(Console.ReadLine());

        if(num1 < num2 && num1 < num3 )
        {
            menor = num1;
            if(num2 < num3)
            {
                meio = num2;
                maior = num3;
            }else
            {
                meio = num3;
                maior = 2;
            }
            Console.WriteLine($"Valores ordenados em ordem crescente: {menor}, {meio}, {maior}");
        } 
        
        else if (num2 < num1 && num2 < num3)
        {
            menor = num2;
            if(num1 < num3)
            {
                meio = num1;
                maior = num3;
            } else
            {
                meio = 3;
                maior = 1;
            }
            Console.WriteLine($"Valores ordenados em ordem crescente: {menor}, {meio}, {maior}");
        }

        else
        {
            menor = num3;
            if(num1 < num2){
                meio = num1;
                maior = num2;
            } else
            {
                meio = num2;
                maior = num1;
            }
            Console.WriteLine($"Valores ordenados em ordem crescente: {menor}, {meio}, {maior}");
        }
    }
}