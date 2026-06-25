//Construa uma função recursiva que calcule e retorne a potenciação – para simplificar, considere o
//expoente um número natural.

using System;

class Program
{
    static void Main()
    {
        Console.Write(Potenciacao(2,3));
    }

    static int Potenciacao(int basee, int expoente)
    {
        if(expoente == 0) return 1;

        return basee * Potenciacao(basee, expoente - 1);
  
    }
}