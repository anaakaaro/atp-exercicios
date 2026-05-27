//Construa uma função que calcule o maior valor presente em uma
//matriz de reais.

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[4, 5]
        {
            {22, 34, 55, 129, 88},
            {54, 36, 30, 20, 15},
            {100, 87, 12, 7, 9},
            {8, 7, 2, 21, 22}
        };

        Console.Write(MaiorValor(matriz));
    } 

    static double MaiorValor(double[,] m)
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