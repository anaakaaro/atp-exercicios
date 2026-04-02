// 6. Ler três lados de um triângulo e, sendo ele válido, identificar o seu tipo: equilátero, isóscele ou
// escaleno. Caso não lembre, busque se informar quais as condições para que três valores quaisquer
// permitam formar um triângulo e quais as condições a serem observadas para classificar um triângulo em
// um de seus três tipos.

using System;
class Exercicio06 {
    static void Main()
    {
        Console.WriteLine("Digite o primeiro valor do lado do triângulo:");
        double lado1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor do lado do triângulo:");
        double lado2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro valor do lado do triângulo:");
        double lado3 = double.Parse(Console.ReadLine());

        if(lado1 == lado2 && lado2 == lado3)
        {
            Console.WriteLine("O triângulo é classificado como equilátero, ou seja, todos os três lados possuem a mesma medida.");
        } else if (lado1 == lado2 || lado1 == lado3)
        {
            Console.WriteLine("O triângulo é classificado como isósceles, ou seja, possui pelo menos dois lados com a mesma medida.");
        } else
        {
            Console.WriteLine("O triângulo é classificado como escaleno, ou seja, todos os três lados possuem medidas diferentes.");
        }
    }
}