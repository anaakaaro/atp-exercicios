//Considere uma turma com n alunos, sendo n um valo lido. Construa um programa
//que leia as notas obtidas pelos alunos [0..100]. Para cada nota lida, o programa
//deverá informar estar o aluno aprovado ou não, sabendo ser sessenta a nota mínima
//requerida para aprovação. Ao final, o programa deverá informar a nota média da turma
//bem como a maior e a menor nota da turma.
//Ao ler a nota de um aluno, rejeita a leitura de nota inválida, sabendo ser cem a nota máxima

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de alunos na turma: ");
        int alunos = int.Parse(Console.ReadLine());
        double somaNotas = 0;
        double nota;
        double maiorNota = 0;
        double menorNota = 100;

        for(int i=1; i <= alunos; i++)
        {
            do
            {
                Console.Write("Digite a sua nota [0..100]: ");
                nota = double.Parse(Console.ReadLine());
                
            }while (nota < 0 || nota > 100);

                if(nota >= 60){
                    Console.WriteLine("Você está aprovado.");
                } else{
                    Console.WriteLine("Você não está aprovado.");
                }

                if(nota > maiorNota){
                    maiorNota = nota;
                }

                if(nota < menorNota){
                    menorNota = nota;
                }

                somaNotas += nota; 
        }
        
        Console.WriteLine($"Nota média da turma: {somaNotas/alunos}");
        Console.WriteLine($"Maior nota da turma: {maiorNota}");
        Console.WriteLine($"Menor nota da turma: {menorNota}");
    }
}
        
