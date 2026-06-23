using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using TrabalhoPratico;

namespace TrabalhoPratico
{
    class Program
    {
        static void Main()
        {
            int totalAlunos = 0;
            Aluno[] alunos = new Aluno[100];

            int opcao;

            do
            {
                opcao = Menu();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        salvarArquivo(alunos, totalAlunos);
                        break;

                    case 2:
                        recuperarArquivo();
                        break;

                    case 3:
                        Console.WriteLine("#### CADASTRANDO ALUNO ####");
                        alunos[totalAlunos] = new Aluno();
                        alunos[totalAlunos].leiaAluno();
                        totalAlunos++;
                        break;

                    case 4:
                        listarAlunos(alunos, totalAlunos);
                        break;

                    case 5:
                        pesquisarAlunosPorNome(alunos, totalAlunos);
                        break;

                    case 6:
                        listarAniversariantesMes(alunos, totalAlunos);
                        break;

                    case 7:
                        totalAlunos = excluirAlunoPorCpf(alunos, totalAlunos);
                        break;

                    case 8:
                        totalAlunos = 0;
                        Console.WriteLine("Todos os alunos foram excluídos.");
                        break;
                }
            } while(opcao != 0);

            
        }

        static void listarAlunos(Aluno[] alunos, int totalAlunos)
        {
            for(int i = 0; i < totalAlunos; i ++)
            {
                alunos[i].escreveAluno();
                Console.WriteLine("########################");
            }
        }

        static void listarAniversariantesMes(Aluno[] alunos, int totalAlunos)
        {
            Console.Write("Digite o mês que deseja visualizar os aniversariantes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine($"### Alunos Aniversariantes do mês {mes} ###");
            for(int i = 0; i < totalAlunos; i++)
            {
                if(alunos[i].getNascimento().getMes() == mes)
                {
                    alunos[i].escreveAluno();
                }
            }
            Console.WriteLine("########################");
        }

        static void pesquisarAlunosPorNome(Aluno[] alunos, int totalAlunos)
        {
            Console.Write("Digite o nome para pesquisa: ");
            string nome = Console.ReadLine();

            bool encontrou = false;

            for (int i = 0; i < totalAlunos; i++)
            {
                if (alunos[i].getNome().ToLower().Contains(nome.ToLower()))
                {
                    alunos[i].escreveAluno();
                    Console.WriteLine("########################");
                    encontrou = true;
                }
            }

            if (!encontrou)
            {
                Console.WriteLine("Nenhum aluno encontrado.");
            }
        }

        static int excluirAlunoPorCpf(Aluno[] alunos, int totalAlunos)
        {
            Console.Write("Digite o CPF do aluno: ");
            string cpf = Console.ReadLine();

            int posicao = -1;

            for (int i = 0; i < totalAlunos; i++)
            {
                if (alunos[i].getCpf() == cpf)
                {
                    posicao = i;
                    break;
                }
            }

            if (posicao == -1)
            {
                Console.WriteLine("Aluno não encontrado.");
                return totalAlunos;
            }

            for (int i = posicao; i < totalAlunos - 1; i++)
            {
                alunos[i] = alunos[i + 1];
            }

            totalAlunos--;

            Console.WriteLine("Aluno removido com sucesso.");

            return totalAlunos;
        }

        static void salvarArquivo(Aluno[] alunos, int totalAlunos)
        {
            StreamWriter arquivo = new StreamWriter("alunos.txt");

            for (int i = 0; i < totalAlunos; i++)
            {
                Data nascimento = alunos[i].getNascimento();
                Data cadastro = alunos[i].getDataCadastro();

                arquivo.WriteLine(
                    $"Nome: {alunos[i].getNome()};" +
                    $"CPF: {alunos[i].getCpf()};" +
                    $"Data de Nascimento: {nascimento.getDia()}/{nascimento.getMes()}/{nascimento.getAno()};" +
                    $"Data de Cadastro: {cadastro.getDia()}/{cadastro.getMes()}/{cadastro.getAno()};" +
                    $"Nota: {alunos[i].getNota()}"
                );
            }

            arquivo.Close();

            Console.WriteLine("Dados salvos com sucesso.");
        }

        static void recuperarArquivo()
        {
            if (!File.Exists("alunos.txt"))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            StreamReader arquivo = new StreamReader("alunos.txt");

            Console.WriteLine("### DADOS DO ARQUIVO ###");

            while (!arquivo.EndOfStream)
            {
                string linha = arquivo.ReadLine();
                Console.WriteLine(linha);
            }

            arquivo.Close();

            Console.WriteLine("########################");
        }

        static void excluirTodosAlunos()
        {
            if (!File.Exists("alunos.txt"))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            File.WriteAllText("alunos.txt", "");

            Console.WriteLine("Todos os alunos foram excluídos.");
        }
        static int Menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("Menu");
                Console.Write("0 - Sair\n" +
                "1 - Salvar os dados dos alunos em um arquivo\n" + 
                "2 - Recuperar os dados dos alunos armazenados em um arquivo\n" +
                "3 - Cadastrar um Aluno\n" + 
                "4 – Listar todos os alunos\n" +
                "5 – Pesquisar alunos por um nome chave de pesquisa\n" +
                "6 – Listar os alunos aniversariantes de um mês chave de pesquisa\n" +
                "7 – Excluir um aluno a partir de um CPF chave de pesquisa\n" +
                "8 – Excluir todos os alunos\n" +
                "Sua opção: ");

                opcao = int.Parse(Console.ReadLine());
            } while(opcao < 0 || opcao > 8);

            return opcao;
            
        }
    }
}




