using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        // Aluno[] alunos = new Aluno[3];
        // int totalAlunos = 0;

        // int opcao = Menu();
        // int i = 0;

        Aluno aluno = new Aluno();
        aluno.setNome("Carol");
        aluno.setNascimento(30,6,2004);
        aluno.setDataCadastro(18,6,2026);
        aluno.setNota(32);

        aluno.escreveAluno();

        // switch (opcao)
        // {
        //     case 0: 
        //         Console.Write("Obrigado!");
        //         break;

        //     case 1: 
        //         alunos[i] = new Aluno();
        //         alunos[i].leiaAluno();
        //         i++;
        //         totalAlunos++;
        //         break;
            
        //     case 2: 
        //         listaAlunos(alunos);
        //         break;
                
        // }
    }

    static void listaAlunos(Aluno[] alunos)
    {
        for(int i = 0; i < alunos.Length; i ++)
        {
            alunos[i].escreveAluno();
        }
    }

    static int Menu()
    {
        int opcao;
        do
        {
            Console.WriteLine("Menu");
            Console.WriteLine("0 - Sair\n" +
            "1 - Cadastrar aluno\n" + 
            "2 - Listar alunos\n" + 
            "Sua opção: ");

            opcao = int.Parse(Console.ReadLine());
        } while(opcao < 0 || opcao > 2);

        return opcao;
        
    }
}

class Data
{
    private int dia;
    private int mes;
    private int ano;

    public bool setDia(int dia)
    {
        bool sucesso = false;

        if(dia >= 0 && dia <= 31)
        {
            this.dia = dia;
            sucesso = true;
        }

        return sucesso;
    }

    public bool setMes(int mes)
    {
        bool sucesso = false;
        
        if(mes >= 0 && mes <= 12)
        {
            this.mes = mes;
            sucesso = true;
        }

        return sucesso;
    }

    public void setAno(int ano)
    {
        this.ano = ano;
    }

    public bool setData(int dia, int mes, int ano)
    {
        bool sucesso = false;

        if(dia >= 0 && dia <= 31 && mes >= 0 && mes <= 12)
        {
            setDia(dia);
            setMes(mes);
            setAno(ano);

            sucesso = true;
        }

        return sucesso;
    }

    public int getDia()
    {
        return dia;
    }

    public int getMes()
    {
        return mes;
    }

    public int getAno()
    {
        return ano;
    }

    public bool dataValida()
    {
        bool dataValida = false;

        if(dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12)
        {
            dataValida = true;
        }

        return dataValida;
    }

    public string mesExtenso(int mes)
    {
        String[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
        string mesExtenso = "";

        switch (mes)
        {
            case 1:
                mesExtenso = meses[0];
                break;

            case 2:
                mesExtenso = meses[1];
                break;

            case 3:
                mesExtenso = meses[2];
                break;

            case 4:
                mesExtenso = meses[3];
                break;

            case 5:
                mesExtenso = meses[4];
                break;

            case 6:
                mesExtenso = meses[5];
                break;

            case 7:
                mesExtenso = meses[6];
                break;

            case 8:
                mesExtenso = meses[7];
                break;

            case 9:
                mesExtenso = meses[8];
                break;

            case 10:
                mesExtenso = meses[9];
                break;

            case 11:
                mesExtenso = meses[10];
                break;

            case 12:
                mesExtenso = meses[11];
                break;
        }

        return mesExtenso;
    }

    public void escreveData()
    {
        Console.WriteLine($"{dia}/{mes}/{ano}");
    }

    public void leiaData()
    {
        Console.Write("Dia: ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Mês: ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        setData(dia, mes, ano);
    }
}

class Aluno
{
    private string? nome;
    private double nota;
    private Data nascimento = new Data();
    private Data cadastro = new Data();

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return nome;
    }

    public bool setNascimento(int dia, int mes, int ano)
    {
        return nascimento.setData(dia, mes, ano);
    }

    public Data getNascimento()
    {
        return nascimento;
    }

    public void setDataCadastro(int dia, int mes, int ano)
    {
        cadastro.setData(dia, mes, ano);
    } 

    public Data getDataCadastro()
    {
        return cadastro;
    }
    
    public bool setNota(double nota)
    {
        bool sucesso = false;

        if(nota >= 0 && nota <= 100)
        {
            this.nota = nota;
            sucesso = true;
        }

        return sucesso;
    }

    public double getNota()
    {
        return nota;
    }
    public void leiaNome()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        setNome(nome);
    }

    public void escrevaNome()
    {
    Console.WriteLine($"Nome do aluno: {nome}");
    }

    public void leiaNota()
    {
        Console.WriteLine("Nota: ");
        double nota = double.Parse(Console.ReadLine());
        setNota(nota);
    }
    public void leiaAluno()
    {
        leiaNome();
        Console.WriteLine("Data de nascimento");
        nascimento.leiaData();
        Console.WriteLine("Data de cadastro");
        cadastro.leiaData();
        leiaNota();
    }

    public void escreveAluno()
    {
        escrevaNome();
        Console.WriteLine($"Nota: {nota}");
        Console.WriteLine($"Data de nascimento: {nascimento}");
        Console.WriteLine($"Data de cadastro: {cadastro}");
    }
}