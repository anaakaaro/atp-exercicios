//Somatório de 1 até n. Conter as funções:
//LerValor()
//Somatorio(int n)

using System;

class Program
{
    static void Main()
    {
        int n = LerValor();
        int somatorio = Somatorio(n);
        Console.WriteLine($"Resultado do somatório: {somatorio}");
    }

    static int LerValor()
    {
        int n;
        bool erro;

        do
        {
            Console.Write("Digite um valor inteiro positivo: ");
            n = int.Parse(Console.ReadLine());

            erro = n < 1;

            if(erro){Console.WriteLine("Digite um valor maior que 1.");}
        } while(erro);

        return n;
    }

    static int Somatorio(int n)
    {
        int soma = 0;
        
        for(int i = 1; i <= n; i++)
        {
            soma += i;
        }
        return soma;

    }
}