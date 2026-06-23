namespace TrabalhoPratico
{
    class Aluno
    {
        private string? nome;
        private string? cpf;
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

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return cpf;
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
            Console.Write("Nota: ");
            double nota = double.Parse(Console.ReadLine());
            setNota(nota);
        }

        public void leiaCpf()
        {
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            setCpf(cpf);
        }

        public void escrevaCpf()
        {
            Console.WriteLine($"CPF: {cpf}");
        }
        public void leiaAluno()
        {
            leiaNome();
            leiaCpf();
            Console.WriteLine("Data de nascimento");
            nascimento.leiaData();
            Console.WriteLine("Data de cadastro");
            cadastro.leiaData();
            leiaNota();
        }

        public void escreveAluno()
        {
            escrevaNome();
            escrevaCpf();
            Console.WriteLine($"Nota: {nota}");
            Console.Write("Data de nascimento: ");
            nascimento.escreveData();

            Console.Write("Data de cadastro: ");
            cadastro.escreveData();
        }
    }
}