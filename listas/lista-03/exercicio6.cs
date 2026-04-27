//Crie uma nova versão para a calculadora. Nela, acrescente ao programa a
//possibilidade de mais que um cálculo ser realizado Para isto, após a escrita do resultado de cada
//operação, o fluxo de execução deverá voltar à apresentação do menu ao usuário do programa. Desta
//forma, o menu deverá ser alterado acrescentando a ele uma nova opção: “S - sair do programa”. Esta
//deverá ser a primeira opção do menu. Quando selecionada, a mensagem “Obrigado por usar este
//programa” deverá ser escrita e o programa finalizado. Caso contrário, tratar a operação aritmética
//selecionada ou informar tratar-se de uma opção inválida.

using System;

class Program
{
    static void Main()
    {
        double a, b, resultado;
        char operacao;

        while (true)
        {
            Console.Write("\nDigite a operação [S - sair, +, -, *, /]: ");
            operacao = char.Parse(Console.ReadLine());

            if (char.ToUpper(operacao) == 'S')
            {
                Console.WriteLine("Obrigado por usar este programa");
                break;
            }

            Console.Write("Digite o 1º número: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            b = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    resultado = a + b;
                    Console.WriteLine($"{a} + {b} = {resultado}");
                    break;

                case '-':
                    resultado = a - b;
                    Console.WriteLine($"{a} - {b} = {resultado}");
                    break;

                case '*':
                    resultado = a * b;
                    Console.WriteLine($"{a} * {b} = {resultado}");
                    break;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Divisão inválida");
                    }
                    else
                    {
                        resultado = a / b;
                        Console.WriteLine($"{a} / {b} = {resultado}");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida");
                    break;
            }
        }
    }
}