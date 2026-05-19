//Construa uma função que identifique o tipo de um triângulo.
//- Parâmetros: três números reais relativos aos três lados de um triângulo
//- Valor gerado: 0, caso os valores dos lados não formem um triângulo
//1, caso equilátero
//2, caso isóscele
//3, caso escaleno

using System;

class Program
{
    static void Main()
    {
        Console.Write(TipoTriangulo(3,3,3));
        
    }

    static int TipoTriangulo(double ladoA, double ladoB, double ladoC)
    {
        if(ladoA >= ladoB + ladoC || 
        ladoB >= ladoA + ladoC || 
        ladoC >= ladoA + ladoB)
        {
            return 0;
        }

        if(ladoA == ladoB && ladoB == ladoC)
        {
            return 1;
        } 
        else if(ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
        {
            return 2;
        }
        else
        {
            return 3;
        }
    }
}
