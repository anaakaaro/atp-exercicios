//Uma capicua é um número que se lê da mesma forma, da direita para esquerda; da esquerda para direita.
//Trata-se de um palíndromo numérico. Exemplos: 1001, 12521, 55
//Crie uma função que receba um número inteiro positivo e verifique se é ele uma capicua ou não.

using System;

class Program
{
    static void Main()
    {
        Console.Write(EhCapicua(12521));
    }

    static bool EhCapicua(int n)
    {
        int invertido = 0;
        int original = n;

        while(n > 0)
        {
            int digito = n % 10;
            invertido = invertido * 10 + digito;
            n /= 10;
        }
        return original == invertido;
    }
}