// 7. Identificar se um ano qualquer é bissexto ou não. Pesquise o que deve ser observado para verificar se
// um ano é bissexto.

using System;
class Exercicio07 {
    static void Main()
    {
        Console.WriteLine("Digite um ano:");
        int ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
        {
            Console.WriteLine($"O ano {ano} é bissexto.");
        }   else
        {
            Console.WriteLine("O ano não é bissexto.");
        }
    }
}