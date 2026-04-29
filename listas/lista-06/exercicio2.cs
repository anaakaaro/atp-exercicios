//Calcular o perímetro de um quadrado.

using System;

class Program{
    static void Main()
    {
        Console.Write(PerimetroQuadrado(6));
    }

    static double PerimetroQuadrado(double lado)
    {
        return lado * 4;
    }
}