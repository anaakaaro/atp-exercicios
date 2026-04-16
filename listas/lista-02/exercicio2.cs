//Um programa deverá prover ao usuário um menu de opções de conversão para medida, a saber:
//1 – De Quilômetros para Milhas
//2 – De Metros para Pés
//3 – De Célsius para Farenheit
//4 – De Quilogramas para Libras
//Após escolher a opção do menu, o usuário deverá informar o valor a ser convertido
using System;

class Program
{
    static void Main()
    {
        double resultado = 0;

        Console.WriteLine("Conversão de medidas \nEscolha uma opção:");
        Console.WriteLine("1 - De Quilômetros para Milhas");
        Console.WriteLine("2 - De Metros para Pés");
        Console.WriteLine("3 - De Célsius para Farenheit");
        Console.WriteLine("4 - De Quilogramas para Libras");

        int opcao = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor a ser convertido: ");
        double valor = double.Parse(Console.ReadLine());

        switch(opcao){

            case 1:
            resultado = valor / 1.609;
            Console.Write($"Resultado da conversão: {resultado} milhas");
            break;

            case 2:
            resultado = valor * 3.281;
            Console.Write($"Resultado da conversão: {resultado} pés");
            break;

            case 3:
            resultado = (valor * 1.8) + 32;
            Console.Write($"Resultado da conversão: {resultado} Farenheit");
            break;

            case 4:
            resultado = valor * 2.205;
            Console.Write($"Resultado da conversão: {resultado} libras");
            break;
        }
    }
}