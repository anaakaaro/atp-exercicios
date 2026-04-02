// 5. Identificar a classificação de uma pessoa quanto ao seu peso. Para isto, primeiro calcule o seu índice de
// massa corporal (desenvolvido na questão 3 desta lista de exercícios). Em seguida, exiba uma mensagem
// ao usuário conforme a tabela abaixo:
// IMC < 18,5 – Abaixo do peso
// IMC de 18,5 a 24,9 – Peso normal
// IMC de 25 a 29,9 – Sobrepeso
// IMC > 30 - Obesidade

using System;
class Exercicio05 {
    static void Main()
    {
        Console.WriteLine("Digite o seu peso:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine($"O seu IMC é: {imc}");

        if(imc < 18.5)
        {
            Console.WriteLine("Você está abaixo do peso.");
        } else if(imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Seu peso está normal.");
        } else if(imc >= 25 && imc <= 29.90)
        {
            Console.WriteLine("Você está com sobrepeso.");
        } else
        {
            Console.WriteLine("Você está com obesidade.");
        }
    }
}