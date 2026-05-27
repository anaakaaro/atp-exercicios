//Visitar e escrever os elementos da diagonal principal

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
        
        EscreverDiag(matriz);
    }

    static void EscreverDiag(double[,] m)
    {
        if(m.GetLength(0) == m.GetLength(1))
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                Console.Write(m[i,i] + " ");
            }
        }
    }
}