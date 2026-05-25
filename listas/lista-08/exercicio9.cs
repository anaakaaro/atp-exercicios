//Construa uma função que receba um arranjo de reais e desloque o maior valor de arranjo para a
//última posição
using System;

class Program
{
    static void Main()
    {
        double[] valores = {5, 99, 3, 6};
        TrocaMaiorValor(valores);

        foreach(double valor in valores)
        {
            Console.Write(valor + ", ");
        }
    }

    static void TrocaMaiorValor(double[] valores)
    {
        double maiorValor = valores[0];
        int posicaoValor = 0;

        for(int i = 1; i <= valores.Length; i++)
        {
            if(valores[i] > maiorValor)
            {
                maiorValor = valores[i];
                posicaoValor = i;
            }
        }

        double temp = valores[valores.Length-1];
        valores[valores.Length - 1] = maiorValor;
        valores[posicaoValor] = temp;
    }
}