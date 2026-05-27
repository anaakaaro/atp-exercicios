//Ler uma matriz de reais
using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[2, 3];
        LerMatriz(matriz);
        
    }

    static void LerMatriz(double[,] m)
    {
        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                Console.WriteLine($"Digite o valor de [{i},{j}]");
                m[i,j] = double.Parse(Console.ReadLine());
            }
        }
    }
}