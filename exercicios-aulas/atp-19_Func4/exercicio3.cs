//Calcular a potenciação (não usar a classe Math).
//Considere apenas expoente com N*

using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.Write(Potenciacao(5,2));
    }
    static int Potenciacao(int baseNum, int expoente)
    {
        int resultado = 1;

        for(int i = 1; i <= expoente; i++)
        {
            resultado *= baseNum;
        }

        return resultado;
    }
}