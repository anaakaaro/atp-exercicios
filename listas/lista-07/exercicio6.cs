//Um número perfeito é aquele cuja soma de seus divisores (excluindo ele mesmo) é igual ao próprio
//número. Exemplo: 28 = 1 + 2 + 4 + 7 + 14.
//Crie uma função que verifique se um número inteiro é perfeito ou não.
//Argumento da função: Um número inteiro objeto da funcionalidade a ser executada
//Valor de retorno: true, caso o argumento seja um número perfeito; ou false, caso contrário

using System;

class Program
{
    static void Main()
    {
        Console.Write(EhPerfeito(28));
    }

    static bool EhPerfeito(int n)
    {
        int soma = 0;

        for (int i = 1; i <=n; i++)
        {
            if(n % i == 0)
            {
                soma += i;
            }
        }

        return soma - n == n;
    }
}