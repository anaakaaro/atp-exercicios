//Identificar se um inteiro é par ou ímpar.

using System;

class Program
{
    static void Main()
    {
        Console.Write(ImparOuPar(5));
    }

    static string ImparOuPar(int x)
    {
        if(x % 2 == 0)
            return "Par";
        else
            return "Ímpar";
    }
}