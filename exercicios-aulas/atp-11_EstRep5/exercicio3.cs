//Calcular o valor de H conforme abaixo. O número de termos deverá ser lido.
//H = 3 + 6 + 9 + 12 + ... + tf
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int t = int.Parse(Console.ReadLine());
        int h = 0;

        for(int i = 1; i <= t; i++)
        {
            Console.Write($"{i*3} ");
            h += i*3;
        }

        Console.WriteLine($"\nResultado de H: {h}");
    }
}