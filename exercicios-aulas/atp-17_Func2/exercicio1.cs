//Receber três números reais e gerar a média deles.
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double c = double.Parse(Console.ReadLine());

        double media = MediaTresNumeros(a, b, c);
        Console.WriteLine($"Média dos números {a}, {b} e {c} = {media}");
    }

    static double MediaTresNumeros(double a, double b, double c)
    {
        double media = (a + b + c) / 3;
        return media;
    }
}