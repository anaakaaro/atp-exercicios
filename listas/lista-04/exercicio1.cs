//Construa uma nova versão para o programa que calcula o peso ideal de uma pessoa. Nela, rejeite a
//leitura de dados fora do domínio em ambos os casos, altura e sexo. Considere os seguintes domínios:
//Sexo: ‘M’, ‘m’, ‘F’, ‘f’
//Altura: 0..2,5

using System;

class Program
{
    static void Main()
    {
        bool erro;
        double pesoIdeal, altura;
        char sexo;


        do
        {
            Console.Write("Informe seu sexo[M/F]: ");
            sexo = char.Parse(Console.ReadLine().ToUpper());

            erro = sexo != 'M' && sexo != 'F'; 
        } while(erro);

        do
        {
            Console.Write("Digite a sua altura[0..2,5]: ");
            altura = double.Parse(Console.ReadLine());

            erro = altura < 0 && altura > 2.5;
        } while(erro);


        if(sexo == 'M')
        {
            pesoIdeal = 52 + (0.75 * (altura*100 - 152.4));
        }
        else
        {
            pesoIdeal = 52 + (0.67 * (altura*100 - 152.4));
        }

        Console.Write($"Seu peso ideal é: {pesoIdeal}");
    }
}