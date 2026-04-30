//Escrever os n primeiros termos de uma P.A.
//Parâmetros: primeiro termo, número de termos e razão

using System;

class Program
{
    static void Main()
    {
        Progressao(2, 5, 2);
        
    }
    static void Progressao (int termo, int n, int razao){
        for(int i = 1; i <= n; i++)
        {
            Console.Write(termo + " ");
            termo += razao;
        }
    }
}
