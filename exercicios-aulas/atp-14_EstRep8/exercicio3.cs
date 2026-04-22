//Eleição do D.A.
//Chapa 1 e Chapa 2
//Flag: zero. Ao encerrar, anunciar a chapa vencedora

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        int votosChapa1 = 0;
        int votosChapa2 = 0;
        
        int voto = LerVoto();

        while(voto != 0)
        {
            if(voto == 1)
            {
                votosChapa1 ++;
            } else
            {
                votosChapa2 ++;
            }

            voto = LerVoto();
        }

        if(votosChapa1 > votosChapa2)
        {
            Console.WriteLine($"Chapa 1 ganhadora com {votosChapa1} votos");
        } else if (votosChapa2 > votosChapa1)
        {
            Console.WriteLine($"Chapa 2 ganhadora com {votosChapa2} votos");
        }
        else
        {
            Console.WriteLine($"Empate entre as duas chapas! \nVotos chapa 1: {votosChapa1}\nVotos chapa 2: {votosChapa2} ");
        }
    }

    static int LerVoto()
    {
        int voto;
        bool erro; 

        do{
        Console.Write("Digite o seu voto [1 para chapa 1 / 2 para chapa 2]: ");
        voto = int.Parse(Console.ReadLine());

        erro = voto != 1 && voto != 2 && voto != 0;

            if (erro)
            {
                Console.WriteLine("Número inválido");
            }

        } while(erro);

        return voto;
    }
}
