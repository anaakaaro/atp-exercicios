//Construa um algoritmo que escreva os números inteiros de dez até um (ordem decrescente). Utilize
//estrutura de repetição com teste no final.
using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        int contador = 10;

        do
        {
            Console.WriteLine(contador);
            contador--;
        } while(contador <= 10 && contador >0);
    }
}