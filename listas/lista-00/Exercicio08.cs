//Calcular e escrever o salário bruto de um funcionário. Dados de entrada: o número de horas trabalhadas
//e o valor de cada hora de trabalho.

using System;
class Exercicio08 {
    static void Main()
    {
        Console.WriteLine("Digite o número de horas trabalhadas:");
        double horasTrabalhadas = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de cada hora de trabalho:");
        double valorHora = double.Parse(Console.ReadLine());

        double salarioBruto = horasTrabalhadas * valorHora;
        Console.WriteLine($"Salário bruto: {salarioBruto}");
    }
}