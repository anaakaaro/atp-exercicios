// Construa uma função que receba uma matriz quadrada de reais. A função deverá retornar a soma dos
//valores que compõem sua diagonal secundária.

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[5, 5]
        {
            {22, 34, 55, 99, 88},
            {54, 36, 30, 20, 15},
            {100, 87, 12, 7, 9},
            {8, 7, 2, 21, 22},
            {39, 67, 70, 21, 40}
        };

        Console.Write(SomaDiagonalSec(matriz));
    }  

    static double SomaDiagonalSec(double[,] m)
    {
        double soma = 0;

        if(m.GetLength(0) == m.GetLength(1))
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                int j = m.GetLength(1) - i - 1;
                soma += m[i,j];
            }
        }

        return soma;
    }
}