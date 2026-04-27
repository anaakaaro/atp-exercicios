//Construa um algoritmo que escreva os números inteiros de dez até um (ordem decrescente). Utilize
//estrutura de repetição com teste no início.

using System;

class Program
{
    static void Main()
    {
        int contador = 10;
        while(contador > 0)
        {
            Console.WriteLine(contador);
            contador--;
        }
    }
}