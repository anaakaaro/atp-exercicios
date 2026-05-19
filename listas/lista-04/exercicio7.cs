//Calcular o valor de H conforme abaixo. O número de termos deverá ser lido.
//H = 2/3 + 3/6 + 4/9 + 5/12 + ... + tf

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());

        int numerador = 2, denominador = 3;
        double h = 0;

        for(int i = 1; i <= n; i++)
        {
            Console.Write($"H = {numerador}/{denominador}");

            if (i < n)
            Console.Write(" + ");
            
            h += (double)numerador/denominador;
            numerador += 1;
            denominador += 3;
        }

        Console.Write($"\nValor de H: {h}");
    }
}