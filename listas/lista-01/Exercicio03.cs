// 3. Calcular e escrever o índice de massa corporal (IMC) de uma pessoa:
// Índice de Massa Corporal: peso / altura2

using System;
class Exercicio03 {
    static void Main()
    {
        Console.WriteLine("Digite o seu peso:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine($"O seu IMC é: {imc}");
    }
}