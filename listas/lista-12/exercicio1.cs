// Construa uma função que calcule o produto de duas matrizes do tipo real, de dimensão NUM_LIN x
// NUM_COL. Teste-a a partir da função principal.

using System;

class Program
{
    static void Main()
    {
        double[,] matriz1 = {
            {1, 2},
            {3, 4}
        };

        double[,] matriz2 = {
            {5, 6},
            {7, 8}
        };

        double[,] produtoMatrizes = ProdutoMatrizes(matriz1, matriz2);
    }

    static double[,] ProdutoMatrizes(double[,] matriz1, double[,]matriz2)
    {
        int linhasMatriz1 = matriz1.GetLength(0);
        int colunasMatriz1 = matriz1.GetLength(1);
        int linhasMatriz2 = matriz2.GetLength(0);
        int colunasMatriz2 = matriz2.GetLength(1);

        if(colunasMatriz1 != linhasMatriz2) return null;

        double[,] resultado = new double[linhasMatriz1,colunasMatriz2];

        for(int i = 0; i < linhasMatriz1; i++)
        {
            for(int j = 0; j < colunasMatriz2; j++)
            {
                double soma = 0;

                for(int x = 0; x < colunasMatriz1; x++)
                {
                    soma += matriz1[i,x] * matriz2[x,j];
                }

                resultado[i,j] = soma;
            }
        }

        return resultado;
    }
}