// Calcular e escrever a área de um círculo.

using System;
class Exercicio04 {
    static void Main()
    {
        Console.WriteLine("Digite o valor do raio do circulo");
        double raio = double.Parse(Console.ReadLine());

        double pi = 3.14;
        double areaCirculo = pi * Math.Pow(raio, 2);
        Console.WriteLine($"O valor da área do circulo é {area}");
    }
}