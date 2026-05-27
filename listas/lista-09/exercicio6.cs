//Construa uma função que calcule a média dos valores presentes em sua diagonal principal. Teste-a a
//partir da função principal

using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[5, 5]
        {
            {6, 24, 99, 62, 7},
            {45, 63, 2, 1, 4},
            {25, 32, 94, 47, 6},
            {1, 2, 3, 4, 5},
            {9, 24, 12, 30, 20}
        };

        Console.WriteLine(CalculaMediaDiagonal(matriz));
    }

    static double CalculaMediaDiagonal(double[,] m)
    {
        double media = 0;
    
        if(m.GetLength(0) == m.GetLength(1))
        {
            double soma = 0;
            int contador = 0;

            for(int i = 0; i < m.GetLength(0); i++)
            {
                soma =+ m[i,i];
                contador++;
            }

            media = soma / contador;
        }

        return media;
    }
}