// 1. Construa um algoritmo que identifique qual o maior valor entre 
// dois números reais lidos.

using System;
class Exercicio01 {
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        if(numero1 > numero2)
        {
            Console.WriteLine($"O número {numero1} é maior que o número {numero2}");
        } else
        {
            Console.WriteLine($"O número {numero2} é maior que o número {numero1}");
        }
    }
}