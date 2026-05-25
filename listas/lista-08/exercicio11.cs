//Construa uma função que receba um arranjo de reais e o ordene em ordem crescente
using System;

class Program
{
    static void Main()
    {
        double[] valores = {7, 9, 66, 32, 87};
        OrdemCrescente(valores);

        foreach(double valor in valores)
        {
            Console.Write(valor + ", ");
        }
    }

    static void OrdemCrescente(double[] valores)
    {
        Array.Sort(valores);
    }
}