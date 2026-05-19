//Calcular o número de divisores de um inteiro

using System;

class Program
{
    static int QuantDivisores(int n)
    {
        int divisores = 0;

        for(int i = 1; i * i <= n; i++)
        {
            if(n % i == 0)
            {
                divisores++;
            }
        }
        return divisores;
    }
}