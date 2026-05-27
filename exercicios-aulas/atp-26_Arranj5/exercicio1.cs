//Preencher uma matriz com zeros

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double [5,3];
        PreencherMatrizZero(matriz);

        foreach(double valor in matriz)
        {
            Console.Write(valor + " ");
        }
    }

    static void PreencherMatrizZero(double[,] m)
    {
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                m[i,j] = 0;
            }
        }
    }
}
