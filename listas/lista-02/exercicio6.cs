//Considere escrever o seu nome na tela utilizando a instrução Write, como abaixo:
//Console.Write(“seu nome”);
//Faça com que tal instrução seja executada 100 vezes. Observe o resultado curioso na tela de monitor de
//vídeo.

using System;

class Progrram
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"{i} - Ana Carolina");
        }
    }
}