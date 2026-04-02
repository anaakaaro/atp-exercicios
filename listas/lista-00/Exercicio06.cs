//Calcular e escrever o peso ideal de uma mulher, sabendo que:
//Peso Ideal de pessoas de gênero feminino: (62.1 x altura) – 44.7

using System;
class Exercicio06 {
    static void Main()
    {
        Console.WriteLine("Digite a sua altura:");
        double alturaMulher = double.Parse(Console.ReadLine());

        double pesoIdealMulher = (62.1 * altura) - 44.7;
        Console.WriteLine($"O seu peso ideal é de {pesoIdealMulherIdeal} kg");
    }
}