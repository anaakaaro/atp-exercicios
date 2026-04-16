//Construa um algoritmo que escreva os números inteiros de dez até um (ordem
//decrescente). Utilize estrutura de repetição com teste no final.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Estrutura com teste no final");
        int numero = 10;
        do{
            Console.WriteLine(numero);
            numero--;
        } while (numero >=1);
    }
}