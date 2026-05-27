//Construa uma função que verifique se uma matriz de reais contém ou não algum valor igual a zero.
//A função deverá retornar verdadeiro, se houver, ou falso, caso contrário.

using System;

class Program
{
    static void Main()
    {
        double[,] m = new double[2,2]{
            {0,3},
            {5,0}
        };

        Console.Write(TemZero(m));
    }

    static bool TemZero(double[,] m)
    {
        bool temZero = false;

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] == 0)
                {
                    temZero = true;
                }
            }
        }

        return temZero;
    }
}