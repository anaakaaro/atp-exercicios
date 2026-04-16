//Construa um programa que escreva os números inteiros de dez até um (ordem
//decrescente). Utilize estrutura de repetição com variável de controle.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Estrutura com variável de controle.");
        for(int x=10; x > 0; x--){
            Console.WriteLine(x);
        }
    }
}