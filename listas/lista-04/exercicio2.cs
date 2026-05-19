//Há controversas sobre qual seria “O Maior de Minas”: Atlético ou Cruzeiro? Construa um programa
//para identificar o perfil da Turma quanto ao time do coração. O programa deverá apresentar o
//percentual de atleticanos, de cruzeirenses e daqueles que afirmam torcer para outros times.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos na turma: ");
        int alunos = int.Parse(Console.ReadLine());

        int cruzeirenses = 0, atleticanos = 0, outros = 0;
        char[] escolhas = {'C', 'A', 'O'};
        char escolha;
        bool erro;

        for (int i = 1; i <= alunos; i++)
        {
            do
            {
                Console.Write("Qual o seu time do coração? \n[A - Atlético] \n[C - Cruzeiro] \n[O - Outro]\n");
                escolha = char.Parse(Console.ReadLine().ToUpper());

                erro = !Array.Exists(escolhas, e => e == escolha);

                if (erro)
                {
                    Console.WriteLine("Digite uma opção válida");
                }

            } while(erro);
            
            if(escolha == 'C') cruzeirenses++;
            else if (escolha == 'A') atleticanos++;
            else outros ++;
        }

        double percentCruzeirenses = (double)cruzeirenses / alunos * 100;
        double percentAtleticanos = (double)atleticanos / alunos * 100;
        double percentOutros = (double)outros / alunos * 100;

        Console.WriteLine($"Total de alunos na turma: {alunos}");
        Console.WriteLine($"Percentual de atleticanos: {percentAtleticanos}%");
        Console.WriteLine($"Percentual de cruzeirenses: {percentCruzeirenses}%");
        Console.WriteLine($"Percentual dos que torcem para outros times: {percentOutros}%");
    }
}