//Construa uma função que receba uma matriz quadrada de reais. A função deverá retornar a média
//dos valores posicionados abaixo da diagonal principal.

using System;

class Program
{
    static void Main()
    {
        
    }

    static double MediaAbaixoDiagonal(double[,] m)
    {
        double media = 0;

        if(m.GetLength(0) == m.GetLength(1))
        {
            int contador = 0;
            double soma = 0;

            for(int i = 1; i < m.GetLength(0); i++)
            {
                for(int j = 0; j < i; j++)
                {
                    soma += m[i,j];
                    contador++;
                }
            }

            media = soma / contador;
        }

        return media;
    }
}