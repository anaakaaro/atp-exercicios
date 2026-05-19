//Identificar se um inteiro é primo ou não.

using System;

class Program
{
    static bool EhPrimo(int x)
    {
        bool ehPrimo = true;

        if(x < 1) return false;

        for(int i = 2; i * i <= x; i++)
        {
            if(x % i == 0)
            {
                ehPrimo = false;
                break;
            }
        }
        return ehPrimo;
    }
}