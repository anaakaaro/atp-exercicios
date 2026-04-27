//Ler três valores reais e ordená-los. Escrever os números na ordem crescente.

using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[3];
        double maior , menor , meio ;

        for(int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o {i+1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        if(numeros[0] >= numeros[1] && numeros[0] >= numeros[2])
        {
            maior = numeros[0];

            if(numeros[1] > numeros[2])
            {
                meio = numeros[1];
                menor = numeros[2];

            } 
            else 
            {
                meio = numeros[2];
                menor = numeros[1];
            }
            
        } 

        else if(numeros[1] >= numeros[0] && numeros[1] >= numeros[2])
        {
            maior = numeros[1];

            if(numeros[0] > numeros[2])
            {
                meio = numeros[0];
                menor = numeros[2];
            }
            else{
                meio = numeros[2];
                menor = numeros [0];
            }
        }

        else
        {
            maior = numeros[2];

            if(numeros[0] > numeros[1])
            {
                meio = numeros [0];
                menor = numeros[1];
            }
            else
            {
                meio = numeros[1];
                menor = numeros[0];
            }
        }

        Console.Write($"Ordem crescente: {menor}, {meio}, {maior}");
        
    }
}