//Escrever uma matriz de reais, por coluna

using System;
class Program
{
    static void Main()
    {
        double[,] matriz = new double[2, 3]
        {
            {9, 9, 9},
            {155, 632, 789}
        };
        EscreverMatriz(matriz);
        
    }

    static void EscreverMatriz(double[,] m)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            for(int i = 0; i < m.GetLength(0); i++)
            {
                Console.Write(m[i,j] + " ");
            }
            Console.WriteLine();
        }
    }

}