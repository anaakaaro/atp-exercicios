//Calcular o valor de H conforme abaixo. O número de termos deverá ser lido.
//H = 2/3 + 3/6 + 4/9 + 5/12 + ... + t
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int t = int.Parse(Console.ReadLine());
        double h = 0;

        for(int i = 1; i <= t; i++)
        {
            double numerador = i + 1;
            double denominador = i * 3;

            Console.Write($"{numerador}/{denominador} ");

            if (i < t){
                Console.Write(" + ");
            }

            h += numerador / denominador;
        }

        Console.Write($"\nValor de H: {h}");
    }
}