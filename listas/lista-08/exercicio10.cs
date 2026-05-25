// Construa uma função que receba um arranjo de reais e desloque o menor valor de arranjo para a
//primeira posição.

using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main()
    {
        double[] valores = {2, 9, 87, 7, 1};
        TrocaMenorValor(valores);

        foreach(double valor in valores)
        {
            Console.Write(valor + ", ");
        }
    }

    static void TrocaMenorValor(double[] valores)
    {
        double menorValor = valores[0];
        int posicaoMenorValor = 0;

        for(int i = 1; i < valores.Length; i++)
        {
            if(valores[i] < menorValor)
            {
                menorValor = valores[i];
                posicaoMenorValor = i;
            }
        }

        double temp = valores[0];
        valores[0] = menorValor;
        valores[posicaoMenorValor] = temp;
    }
}
