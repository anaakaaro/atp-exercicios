// Calcular e escrever a soma de dois números reais lidos

using System;
class Exercicio01 {
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Número digitado: {numero1}");

        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Número digitado: {numero2}");

        double soma = numero1 + numero2;
        Console.WriteLine($"{numero1} + {numero2} = {soma}");
    }
}