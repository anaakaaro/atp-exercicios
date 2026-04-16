using System;
using Microsoft.VisualBasic;

class URI {

    static void Main(string[] args) { 

        int respotasCorretas = 0;
        int t = int.Parse(Console.ReadLine());
        Strings[] respostas = Console.ReadLine().Split(' ');

        for(int i = 0; i < 5; i++)
        {
            resposta = int.Parse(Console.ReadLine());
            
            if(int.Parse(respotas[i]) == t)
            {
                respotasCorretas ++;
            }
        }
        Console.WriteLine(respotasCorretas);
    }
}