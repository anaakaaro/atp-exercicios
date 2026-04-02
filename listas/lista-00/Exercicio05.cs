//Calcular e escrever o peso ideal de um homem, sabendo que:
//Peso Ideal de pessoas de gênero masculino: (72.7 x altura) – 58

using System;
class Exercicio05 {
    static void Main()
    {
        Console.WriteLine("Digite a sua altura:");
        double alturaHomem = double.Parse(Console.ReadLine());

        double pesoIdealHomem = (72.7 * altura) - 58;
        Console.WriteLine($"O seu peso ideal é de {pesoIdealHomemIdeal} kg");
    }
}