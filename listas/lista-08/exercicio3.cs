//Construa uma função que receba um arranjo de reais. A função deverá trocar o primeiro elemento do
//arranjo com o último

using System;

class Program
{
    static void Main()
    {
        double[] array = {1,3,6,7};
        TrocaElementos(array);

        foreach(double numero in array)
        {
            Console.Write(numero + " ");
        }
    }

    static void TrocaElementos(double[] numeros)
    {
        double temp = numeros[numeros.Length-1];
        numeros[numeros.Length-1] = numeros[0];
        numeros[0] = temp;
    }
}