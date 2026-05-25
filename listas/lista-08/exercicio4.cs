//Construa uma função que receba um arranjo de reais. A função deverá trocar dois elementos de
//lugar. As duas posições deverão também ser parametrizadas.

using System;

class Program
{
    static void Main()
    {
        double[] array = {5,9,3,4,2,0};
        TrocaDoisElementos(array, 0,3);


        foreach(double numero in array)
        {
            Console.Write($"{numero}, ");
        }
    }

    static void TrocaDoisElementos(double[] numeros, int posicao1, int posicao2)
    {
       double temp = numeros[posicao1];
       numeros[posicao1] = numeros[posicao2];
       numeros[posicao2] = temp;
    }
}