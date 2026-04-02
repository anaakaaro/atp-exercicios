// 2. Construa um algoritmo que verifique qual o maior valor entre 
// três números reais lidos.

using System;
class Exercicio02 {
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        double numero3 = double.Parse(Console.ReadLine());

        if(numero1 > numero2)
        {
            double maiorNumero = numero1;
            if(numero3 > maiorNumero)
            {
                Console.WriteLine($"O maior número é o {numero3}");
            } else
            {
                Console.WriteLine($"O maior número é o {maiorNumero}");
            }
        } else if (numero2 > numero1)
        {
            double maiorNumero = numero2;
            if(numero3 > maiorNumero)
            {
                Console.WriteLine($"O maior número é o {numero3}");
            } else
            {
                Console.WriteLine($"O maior número é o {maiorNumero}");
            }
        } 
    }
}