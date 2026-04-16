//Escrever na tela do monitor de vídeo os números pares compreendidos em um intervalo fornecido pelo
//usuário. Para isto, solicite ao usuário os dois valores do intervalo: limite inferior (valor inicial) e limite
//superior (valor final)

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor inicial: ");
        int valorInicial = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor final: ");
        int valorFinal = int.Parse(Console.ReadLine());

        if(valorInicial < valorFinal){
            while(valorInicial <= valorFinal)
            {
                if(valorInicial % 2 == 0)
                {
                    Console.WriteLine(valorInicial);
                }
                valorInicial++;
            }
        } else
        {
            while(valorInicial >= valorFinal)
            {
                if(valorInicial % 2 == 0)
                {
                    Console.WriteLine(valorInicial);
                }
                valorInicial--;
            }
        }
    }
}