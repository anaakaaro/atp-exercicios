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

        AcimaDiagonal(matriz);
    }
    static void AcimaDiagonal(double[,] m)
    {
        if(m.GetLength(0) == m.GetLength(1))
        {
            for(int j = 1; j < m.GetLength(1); j++)
            {
                for(int i = 0; i < j; i++)
                {
                    Console.Write(m[i,j] + " ");
                }
            }
        }
    }
}