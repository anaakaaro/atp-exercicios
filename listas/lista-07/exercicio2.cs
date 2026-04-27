//Implemente uma função que receba um número inteiro positivo e retorne a soma de todos os seus
//dígitos. Exemplo:
//Entrada: 538 → Saída: 16
//Argumento da função: Um número inteiro objeto da funcionalidade a ser executada
//Valor de retorno: Um valor inteiro relativo à soma dos dígitos do argumento da função

using System;

class Program
{
    static void Main()
    {
        int n;

        do
        {
            Console.Write("Digite um valor inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

        } while(n<0);

        Console.Write($"Soma dos dígitos do número {n} = {SomaDigitos(n)}");
    }

    static int SomaDigitos(int n)
    {
        int soma = 0;

        while(n > 0)
        {
            int digito = n % 10;
            soma += digito;
            n /= 10;
        }

        return soma;
    }
}