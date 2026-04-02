// Calcular e escrever o perímetro e a área de um quadrado.

using System;
class Exercicio03 {
    static void Main()
    {
        Console.WriteLine("Digite o valor do lado do quadrado:");
        double lado = double.Parse(Console.ReadLine());

        double perimetro = lado*4;
        Console.WriteLine($"O valor do perímetro do quadrado é {perimetro}");

        double areaQuadrado = Math.Pow(lado, 2);
        Console.WriteLine($"O valor da área do quadrado é {area}");
    }
}