using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro segundo número");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a operção:");
        char operacao = Console.ReadKey().KeyChar;

        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                break;

            case '-':
                resultado = numero1 - numero2;
                break;

            case '/':
                if(numero2 == 0)
                {
                    Console.WriteLine("\nNão é possível fazer uma divisão por 0.");
                }
                else
                {
                    resultado = numero1 / numero2;
                }
                break;

            case '*':
                resultado = numero1 * numero2;
                break;

            default:
                Console.WriteLine("\nOperação inválida, tente novamente.");
                break;
        }

        Console.WriteLine($"\nResultado da operação: {resultado}");
    }
}