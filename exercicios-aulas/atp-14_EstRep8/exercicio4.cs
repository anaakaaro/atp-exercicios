//Calcular o perfil da turma quanto à faixa etária dos alunos:
//maior idade, menor idade e a amplitude.
//Rejeitar a leitura de valores inválidos. Flag: idade igual a zero

using System;

class Program
{
    static void Main()
    {
        int idade = LerIdade();

        int maiorIdade = idade;
        int menorIdade = idade;

        while(idade != 0)
        {
            if(idade > maiorIdade)
            {
                maiorIdade = idade;
            } 

            if(idade < menorIdade)
            {
                menorIdade = idade;
            }

            idade = LerIdade();
        }

        int amplitude = maiorIdade - menorIdade;

        Console.WriteLine($"Maior idade da turma: {maiorIdade}");
        Console.WriteLine($"Menor idade da turma: {menorIdade}");
        Console.WriteLine($"Amplitude: {amplitude}");
    }

    static int LerIdade()
    {
        int idade;
        bool erro;

        do
        {
            Console.Write("Digite a sua idade [0..150]: ");
            idade = int.Parse(Console.ReadLine());

            erro = idade < 0 || idade > 150;

            if (erro)
            {
                Console.WriteLine("Digite uma idade válida.");
            }

        } while (erro);

        return idade;
    }
}