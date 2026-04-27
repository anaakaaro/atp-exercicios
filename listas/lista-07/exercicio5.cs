//Construa uma função que leia o estado civil, sabendo ser o domínio igual a ‘S’, ‘C’, ‘D’, ‘V’, onde:
//S = solteiro
//C = casado
//D = divorciado
//V = viúvo
//A função deverá retornar o caractere em maiúsculo.
//Implementar a consistência dos dados, isto é, rejeitar a leitura de valores inválidos forçando, neste
//caso, uma nova leitura.

using System;

class Program
{
    static void Main()
    {
        Console.Write(EstadoCivil());
    }

    static char EstadoCivil()
    {
        char estadoCivil;
        char[] estadosCivis = {'s', 'c', 'd', 'v'};
        bool erro;

        do
        {
            Console.Write("Digite seu estado civil: ");
            estadoCivil = char.Parse(Console.ReadLine());

            estadoCivil = char.ToLower(estadoCivil);
            
            erro = !Array.Exists(estadosCivis, e => e == estadoCivil);

        } while(erro);

        return char.ToUpper(estadoCivil);
    }
}