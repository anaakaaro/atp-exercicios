//Construa uma função que calcule e retorne o maior valor presente em uma matriz de reais.

using System;

class Program
{
    static void Main()
    {
        double[,] m = new double[2, 4]
        {
            {18.9, 40, 55.7, 99},
            {4, 14, 87, 91}
        };

        Console.Write(MaiorValorMatriz(m));
    }

    static double MaiorValorMatriz(double[,] m)
    {
        double maiorValor = m[0,0];

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] > maiorValor)
                {
                    maiorValor = m[i,j];
                }
            }
        }

        return maiorValor;
    }
}