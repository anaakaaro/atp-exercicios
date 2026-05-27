//Construa uma função que receba uma matriz quadrada de reais. A função deverá visitar e escrever os
//elementos posicionados acima da diagonal principal. Caso a função não receba uma matriz quadrada,
//ela deverá retornar o valor zero

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[4, 4]
        {
            {1, 2, 3, 4},
            {4, 3, 2, 1},
            {2, 1, 4, 3},
            {3, 4, 1, 2}
        };

        MatrizQuadrada(matriz);

    }

    static void MatrizQuadrada(double[,] m)
    {
        if(m.GetLength(0) == m.GetLength(1))
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < m.GetLength(1); j++)
                {
                    if(i < j)
                    {
                        Console.Write(m[i,j] + " ");
                    }
                }
            }
        }
        else
        {
            Console.Write(0);
        }
    }
}