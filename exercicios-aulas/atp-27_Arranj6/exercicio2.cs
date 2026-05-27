//Construa uma função que calcule o maior valor presente em sua
//diagonal principal.

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

        Console.Write(MaiorValorDiag(matriz));
    }

    static double MaiorValorDiag(double[,] m)
    {
        double maiorValor = 0;

        if(m.GetLength(0) == m.GetLength(1))
        {
            maiorValor = m[0,0];
            for(int i = 1; i < m.GetLength(0); i++)
            {
                if(m[i,i] > maiorValor)
                {
                    maiorValor = m[i,i];
                }
            }
        }
        
        return maiorValor;
    }
}