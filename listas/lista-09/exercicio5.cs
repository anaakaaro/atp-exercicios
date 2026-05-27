//Construa uma função que receba duas matrizes de reais de uma mesma dimensão. A função deverá
//gerar o número de ocorrências de valores iguais em uma mesma posição.

using System;

class Program
{
    static void Main()
    {
        
    }

    static int ValoresIguais(double[,] m, double[,] n)
    {
        int valoresIguais = 0;

        if(m.GetLength(0) == n.GetLength(0) && m.GetLength(1) == n.GetLength(1))
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if(m[i,i] == n[i, i])
                    {
                        valoresIguais++;
                    }
                }
            }
        }
    }
}