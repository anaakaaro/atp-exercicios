//Calcular a potenciação

using System;

class Program
{
    static void Main()
    {
        Console.Write(Potenciacao(5,-2));
    }

    static int Potenciacao(int baseNum, int expoente)
    {
        int potenciacao = 1;

        if(expoente < 0)
        {
            throw new ArgumentException("O expoente não pode ser negativo.");
        }

        for(int i = 0; i < expoente; i++)
        {
            potenciacao *= baseNum;
        }
    
        return potenciacao;
    }
}