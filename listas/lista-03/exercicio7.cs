//Identificar o perfil da turma:
//Percentual de homens
//Percentual de mulheres
//Idade média da turma

using System;

class Program
{
    static void Main()
    {
        bool erro;
        int mulheres = 0, homens = 0, somaIdade = 0;

        Console.Write("Digite a quantidade de alunos na turma: ");
        int alunos = int.Parse(Console.ReadLine());

        for(int i = 1; i <= alunos; i++)
        {
            do{
                Console.Write($"Digite o gênero do {i}º aluno [M/F]: ");
                char genero = char.Parse(Console.ReadLine().ToUpper());

                erro = genero != 'M' && genero != 'F';

                if(erro)
                {
                    Console.WriteLine("Digite um gênero válido [M/F]");
                }

            } while(erro);

            if(genero == 'M') homens++;
            else mulheres++;

            do{
                Console.Write($"Digite a idade do {i}º aluno: ");
                int idade = int.Parse(Console.ReadLine());

                erro = idade <0 || idade > 150;

                if (erro)
                {
                    Console.Write("Digite uma idade válida [0..150]");
                }
            } while(erro);
        
            somaIdade += idade;
        }

        double percentMulheres = (double)mulheres/alunos * 100;
        double percentHomens = (double)homens/alunos * 100;
        int idadeMedia = somaIdade / alunos;

        Console.WriteLine($"Total de alunos na turma: {alunos}");
        Console.WriteLine($"Percentual de mulheres: {percentMulheres}");
        Console.WriteLine($"Percentual de homens: {percentHomens}");
        Console.WriteLine($"Idade média da turma: {idadeMedia}");

        
    }
}
