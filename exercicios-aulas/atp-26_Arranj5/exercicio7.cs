//Visitar e escrever os elementos posicionados acima
//da diagonal principal

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[3, 3]
        {
            {7, 9, 4},
            {8, 2, 4},
            {7, 5, 9}
        };

        EscreveAcimaDiag(matriz);
    }

    static void EscreveAcimaDiag(double[,] m)
    {
        if(m.GetLength(0) == m.GetLength(1))
        {
            for(int j = 1; j < m.GetLength(0); j++)
            {
                for(int i = 0; i < j; i++)
                {
                    Console.Write(m[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}