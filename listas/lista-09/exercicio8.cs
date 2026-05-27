//Construa uma função que receba uma matriz quadrada de reais e dois valores inteiros, i e j, relativos
//à uma linha e à uma coluna, respectivamente. A função deverá verificar se a linha i da matriz é
//exatamente igual à coluna j. A função deverá retornar verdadeiro, se iguais; ou falso, caso contrário.

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[5, 5]
        {
            {1, 1, 1, 1, 1},
            {2, 63, 2, 1, 4},
            {1, 32, 94, 47, 6},
            {1, 2, 3, 4, 5},
            {1, 24, 12, 30, 20}
        };

        Console.WriteLine(LinhaIgualColuna(matriz, 0, 0));
    }

    static bool LinhaIgualColuna(double[,] m, int i, int j)
    {
        bool saoIguais = false;

        if(m.GetLength(0) == m.GetLength(1) && i >= 0 && i < m.GetLength(0) && j >=0 && j < m.GetLength(1))
        {
            int x = 0;
            saoIguais = true;

            while(saoIguais && x < m.GetLength(1))
            {
                if(m[x,j] != m[i, x])
                {
                    saoIguais = false;
                }

                x++;
            }
        }

        return saoIguais;

    }

     

}