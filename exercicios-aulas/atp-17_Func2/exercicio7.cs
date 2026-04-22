//Contar o número de dígitos em um inteiro decimal.
//Conter as funções:
//LerInteiro()
//QtDigitos(int n)

using System;

class Program
{
    static void Main()
    {
        int x = LerInteiro();
        Console.WriteLine($"Quantidade de digitos no número {x}: {QtDigitos(x)}");
    }

    static int LerInteiro()
    {
        Console.WriteLine("Digite um  número inteiro: ");
        int x = int.Parse(Console.ReadLine());

        return x;
    }

    static int QtDigitos(int x)
    {
        int contador = 0;

        while (x > 0)
        {
            x /= 10;
            contador++;
        }

        return contador;
    }
}