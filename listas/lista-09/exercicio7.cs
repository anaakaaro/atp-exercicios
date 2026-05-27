//Construa uma função que receba uma matriz quadrada de reais e dois valores inteiros, i e j, relativos
//à uma linha e à uma coluna, respectivamente. A função deverá verificar se a soma dos valores da
//linha i é igual à soma dos valores da coluna j.

using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[3, 3]
        {
          {1, 2, 3},
          {3, 2, 1},
          {1, 2, 2}  
        };

        Console.Write(SomaEhIgual(matriz, 0, 0));
    }

    static bool SomaEhIgual(double [,]m, int i, int j)
    {
        bool ehIgual = false;

        if(m.GetLength(0) == m.GetLength(1) && i < m.GetLength(0) && i >= 0 && j < m.GetLength(1) && j >=0)
        {
            if(SomaLinha(m,i) == SomaColuna(m, j))
            {
                ehIgual = true;
            }
        }

        return ehIgual;
    }

    static double SomaLinha(double[,]m, int i)
    {
        double soma = 0;

        if(i >= 0 && i < m.GetLength(0))
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                soma += m[i,j];
            }
        }

        return soma;
    }

    static double SomaColuna (double[,] m, int j)
    {
        double soma = 0;

        if(j >= 0 && j < m.GetLength(1))
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                soma += m[i,j];
            }
        }
        return soma;
    }
}