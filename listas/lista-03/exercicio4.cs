//Calcular o número de dias vividos até o último aniversário. Ignorar anos bissextos. Rejeitar idade
//inválida, sabendo que: idade 0..150

using System;

class Program
{
    static void Main()
    {
        bool erro;
        int idade;

        do
        {
            Console.Write("Digite a sua idade [0..150]: ");
            idade = int.Parse(Console.ReadLine());
            erro = idade < 0 || idade > 150;

            if (erro)
            {
                console.WriteLine("Digite uma idade válida!");
            }

        } while (erro);

        int diasVividos = idade * 365;
        Console.WriteLine($"Seus dias vividos até o seu último aniversário: {diasVividos}");
    }
}