//Calcular e escrever a representação em Farenheit de uma temperatura em graus celsius. Uma medida em
//celsius pode ser convertida em Farenheit através da seguinte fórmula:
//Fahrenheit = celsius x 1.8 + 32

using System;
class Exercicio07 {
    static void Main()
    {
        Console.WriteLine("Digite a temperatura em graus celsius:");
        double grausCelsius = double.Parse(Console.ReadLine());

        double farenheit = (grausCelsius * 1.8) + 32;
        Console.WriteLine($"Temperatura em Farenheit: {farenheit}");
    }
}