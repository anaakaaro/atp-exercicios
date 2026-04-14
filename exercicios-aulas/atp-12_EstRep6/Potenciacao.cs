//Calcular e escrever a potenciação. A base e o expoente deverão ser
//valores lidos – rejeitar a leitura de valores inválidos.
//Considere: base um valor real.
//Expoente: um número natural: inteiro, positivo ou nulo(zero).
//Obs: A potenciação deverá ser calculada de forma iterativa (não
//utilizar função matemática).

using System;

class Program{
    static void Main(){
        Console.Write("Digite a base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.Write("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());
        
        int pot = 1;

        for(int i = 1; i <= expoente; i++)
        {
            pot *= baseNum;
        }

        Console.WriteLine($"{baseNum} ^ {expoente} = {pot}");

    }
}