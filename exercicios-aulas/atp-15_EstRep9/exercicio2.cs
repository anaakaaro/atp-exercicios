//Calcular o fatorial de um inteiro positivo lido.

using System;

class Program
{
    static void Main()
    {
        int x;
        int fatorial = 1;
        bool erro; 

        do{
            Console.WriteLine("Digite o número: ");
            x = int.Parse(Console.ReadLine());
            erro = x <0;

            if (erro)
            {
                Console.WriteLine("Digite um número maior ou igual a 0.");
            }
        }while (erro);

        for(int i = 1; i <= x; i++)
        {
            fatorial *= i;
        }

        Console.WriteLine($"Fatorial de {x} = {fatorial}");
    }
}