//Construa uma função que verifique se uma matriz de reais contém ou
//não algum valor igual a zero. A função deverá retornar verdadeiro, se
//houver, ou falso, caso contrário.

using System;
using System.Globalization;

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

        Console.Write(TemZero(matriz));
    }

    static bool TemZero(double[,] m)
    {
        bool temZero = false;
        int i = 0;

        while(!temZero && i < m.GetLength(0))
        {
            int j = 0;

            while(!temZero && j < m.GetLength(1))
            {
                if(m[i,j] == 0)
                {
                    temZero = true;
                }

                j++;
            }
            i++;
        }

        return temZero;
    }
}