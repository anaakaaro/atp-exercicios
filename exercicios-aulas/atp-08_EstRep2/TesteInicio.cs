//Construa um algoritmo que escreva os números inteiros de dez até um (ordem
//decrescente). Utilize estrutura de repetição com teste no início.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Estrutura com teste no início");
        int numero = 10;
        while (numero >= 1){
            Console.WriteLine(numero);
            numero--;
        }
    }
}