//Construa um programa que permita identificar o perfil da turma:
//- Percentual de homens e de mulheres.
//- Percentual de alunos maiores em idade.
//- Idade da pessoa mais velha.
//- Idade da pessoa mais nova.
//Domínio dos dados:
//Gênero: m/f, sendo ‘m’=masculino e ‘f’=feminino.
//Idade: 0..150
//• Deverão ser rejeitados os valores lidos fora do domínio (observe que aqui deve
//ser utilizada a est. de rep. com teste no final)
//* O número de alunos da turma deverá ser um valor lido

using System;

class Program
{
    static void Main()
    {
        //Lê o número de alunos
        Console.Write("Digite o número de alunos da turma: ");
        int alunos = int.Parse(Console.ReadLine());

        char sexo;
        int idade, maisVelha = 0, maisNova = 150, homens = 0, mulheres = 0, maiorIdade = 0;
        double percentHomens, percentMulheres, percentMaiorIdade;
        bool erro;

        for(int i = 1; i <= alunos; i++)
        {
            //do while para validar se a entrada está dentro do domínio
            do
            {
                Console.Write($"Digite a idade do {i}º aluno [0..150]: ");
                idade = int.Parse(Console.ReadLine());
                erro = idade < 0 || idade > 150;

                if(erro){Console.WriteLine("Digite uma idade válida");}
            
            } while(erro);

            if(idade > maisVelha){maisVelha = idade;}
            if(idade < maisNova){maisNova = idade;}
            if(idade >= 18){maiorIdade++;}

            do
            {
                Console.Write($"Digite o sexo do {i}º aluno [m ou f]: ");
                sexo = char.Parse(Console.ReadLine());
                erro = sexo != 'm' && sexo != 'M' && sexo != 'f' && sexo != 'F';
                if(erro){Console.WriteLine("Digite um sexo válido");}

            } while(erro);

            if(sexo == 'f' || sexo =='F'){mulheres++;}
            else{homens++;}
        }

        percentHomens = (double)homens/alunos *100;
        percentMulheres = (double)mulheres/alunos *100;
        percentMaiorIdade = (double)maiorIdade/alunos *100;

        Console.WriteLine($"Pessoa mais velha: {maisVelha}");
        Console.WriteLine($"Pessoa mais nova: {maisNova}");
        Console.WriteLine($"Percentual de homens: {percentHomens}%");
        Console.WriteLine($"Percentual de mulheres: {percentMulheres}%");
        Console.WriteLine($"Percentual de maiores em idade: {percentMaiorIdade}%");
    }
}