//Construa uma função que identifique o maior valor presente na linha i
//de uma matriz de reais, sendo i também um argumento da função.

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

        Console.Write(MaiorValorLinha(matriz, 2));
    }

    static double MaiorValorLinha(double[,] m, int i)
    {
        double maior = m[i,0];
        
        for(int j = 1; j < m.GetLength(1); j++)
        {
            if(m[i,j] > maior)
            {
                maior = m[i,j];
            }
        }

        return maior;
    }
}