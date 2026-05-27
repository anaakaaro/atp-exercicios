//Construa uma função que calcule e retorne o número de ocorrências de valores iguais a zero em uma
//matriz de reais.

using System;

class Program
{
    static void Main()
    {
        double[,] m = new double[2,2]{
            {0,3},
            {5,0}
        };

        Console.Write(ValoresIgualAZero(m));
    }

    static int ValoresIgualAZero(double[,] m)
    {
        int qtdZero = 0;

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] == 0)
                {
                    qtdZero++;
                }
            }
        }

        return qtdZero;
    }
}