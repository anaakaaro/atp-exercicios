//Calcular o valor de H conforme abaixo. O número de termos deverá ser lido.
//H = 3 + 6 + 9 + 12 + ... + tf

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de termos: ");
        int n = int.Parse(Console.ReadLine());
        int h = 0;

        for(int i = 1; i <= n; i++)
        {
            int termo = i * 3;
            Console.Write(termo + " ");
            h += termo;
        }

        Console.Write($"\nValor de H = {h}");
    }
}