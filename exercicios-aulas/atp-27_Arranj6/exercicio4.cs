//Construa uma função que verifique o número de ocorrências de
//valores iguais a zero em uma matriz de reais

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[4, 5]
        {
            {0, 34, 55, 129, 88},
            {54, 0, 30, 20, 15},
            {100, 87, 12, 7, 0},
            {8, 0, 2, 0, 22}
        };

        Console.Write(NumerosZero(matriz));
    }

    static int NumerosZero(double[,] m )
    {
        int contador = 0;

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] == 0)
                {
                    contador++;
                }
            }
        }

        return contador;
    }
}
