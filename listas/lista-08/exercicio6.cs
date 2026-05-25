//Construa uma nova versão para o problema anterior de forma que, ao final das leituras, também seja
//informado o percentual de alunos aprovados, sabendo ser sessenta a nota mínima para aprovação.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos na turma: ");
        int alunos = int.Parse(Console.ReadLine());

        double totalNotas = 0;
        int notasAcimaMedia = 0;

        double[] notas = new double[alunos];

        for(int i = 0; i < alunos; i++)
        {
            double notaAluno;

            do
            {
                Console.Write($"Digite a nota do {i + 1}º aluno: ");
                notaAluno = double.Parse(Console.ReadLine());

                if(notaAluno < 0 || notaAluno > 100)
                {
                    Console.WriteLine("Digite uma nota válida.");
                }

            } while(notaAluno < 0 || notaAluno > 100);

            notas[i] = notaAluno;
        }

        //somar todas as notas
        foreach(double nota in notas)
        {
            totalNotas += nota;
        }

        //nota media
        double notaMediaTurma = totalNotas / alunos;

        //alunos com nota superior a media
        foreach(double nota in notas)
        {
            if(nota > notaMediaTurma) notasAcimaMedia++;
        }

        //verificar maior e menor nota para amplitude
        double maiorNota = notas[0];
        double menorNota = notas[0];

        foreach(double nota in notas)
        {
            if(nota > maiorNota) maiorNota = nota;
            if(nota < menorNota) menorNota = nota;
        }

        int alunosAprovados = 0;
        foreach(double nota in notas)
        {
            if(nota >= 60) alunosAprovados++;
        }
        

        Console.WriteLine($"Nota média da turma: {notaMediaTurma}");
        Console.WriteLine($"Alunos com nota superior a nota média da turma: {notasAcimaMedia}");
        Console.WriteLine($"Amplitude das notas: {maiorNota-menorNota}");
        Console.WriteLine($"Percentual de alunos aprovados: {(double)alunosAprovados/alunos * 100}%");
    }

    
}

