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
        Console.Write(QtDigitos(x));
        
    }

    static int QtDigitos(int x)
    {
        int digitos = 0;

        while(x > 0)
        {
            x /= 10;
            digitos++;
        }

        return digitos;
    }
    static int LerInteiro()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        return numero;
    }
}

