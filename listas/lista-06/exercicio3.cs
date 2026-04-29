//Identificar se um inteiro é par ou ímpar.

using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        ImparOuPar(2);
    }

    static void ImparOuPar(int x)
    {
        if(x % 2 == 0)
        {
            Console.Write($"O número {x} é par.");
        }
        else
        {
            Console.Write($"O número {x} é ímpar.");
        } 
    }

}