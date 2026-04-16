//Construa uma nova versão para o programa que calcula o peso ideal de uma
//pessoa. Nela, rejeite a leitura de dados fora do domínio em ambos os casos,
//altura e sexo. Considere os seguintes domínios:
//Sexo: ‘M’, ‘m’, ‘F’, ‘f’
//Altura: 0..2,5
using System;

class Program
{
    static void Main()
    {
        char sexo;
        double altura, pesoIdeal;
        bool erro;

        do{
            Console.Write("Digite seu sexo [M /F]: ");
            sexo = char.Parse(Console.ReadLine());

            erro = sexo != 'M' && sexo != 'F' && sexo != 'm' && sexo != 'f';
            if (erro)
            {
                Console.WriteLine("Valor não previsto");
            }
        }while(erro);

        do
        {
            Console.Write("Digite a sua altura [0..2,5]: ");
            altura = double.Parse(Console.ReadLine());

            erro = altura < 0 || altura > 2.5;
            if (erro)
            {
                Console.WriteLine("Valor não previsto");
            }
        }while(erro);

        if(sexo == 'M' || sexo == 'm')
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }

        Console.Write($"Seu peso ideal é: {pesoIdeal}");
    }
}