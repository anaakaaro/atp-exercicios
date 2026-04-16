using System;

class Medidas
{
    static void Main()
    {
        Console.WriteLine("Conversor de medidas");
        Console.WriteLine("\nEscolha a conversão desejada:");
        Console.WriteLine("\n1- De Quilômetros para Milhas");
        Console.WriteLine("\n2- De Metros para Pés");
        Console.WriteLine("\n3- De Célsius para Farenheit");
        Console.WriteLine("\n4- De Quilogramas para Libras");
        int conversao = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o valor a ser convertido:");
        double valor = double.Parse(Console.ReadLine());
        double resultado = 0;

        switch (conversao)
        {
            case 1:
                resultado = valor * 0.6214;
                break;

            case 2:
                resultado = valor * 3.281;
                    break;

            case 3:
                resultado = (valor * 1.8) + 32;
                break;

            case 4:
                resultado = valor * 2.205;
                break;

            default:
                Console.WriteLine("\nDigite uma opção válida.");
                break;
        }

        Console.WriteLine($"\nResutado da conversão: {resultado}");
    }
}