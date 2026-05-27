//Cada elemento com valor igual a i + j

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double [5,3];
        PreencherMatrizSoma(matriz);

        foreach(double valor in matriz)
        {
            Console.WriteLine(valor + " ");
        }
    }

    static void PreencherMatrizSoma(double[,] m)
    {
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                m[i,j] = i + j;
            }
        }
    }
}