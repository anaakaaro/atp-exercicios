//Escreva uma função que receba um número inteiro positivo e retorne o número “invertido”. Exemplo:
//Entrada: 1234 → Saída: 4321.

using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Digite um número inteiro positivo: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0);

        Console.Write($"Número invertido de {n} = {ValorInvertido(n)}");
    }

    static int ValorInvertido(int n)
    {
        int valorInvertido = 0;

        while(n > 0)
        {
            int digito = n % 10;
            valorInvertido = valorInvertido * 10 + digito;
            n /= 10;
        }

        return valorInvertido;
    }
}