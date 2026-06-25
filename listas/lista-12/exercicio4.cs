class Pessoa
{
    private string nome;
    private int idade;

    public Pessoa(){}

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    public string getNome()
    {
        return nome;
    }

    public void setIdade(int idade)
    {
        if(idade >= 0 && idade <= 150)
        {
            this.idade = idade;
        }
    }

    public int getIdade()
    {
        return idade;
    }

    // Para a classe acima, implemente o método ehMaior():booleano. Ele deve descrever uma operação
    // que verifique se é uma pessoa maior em idade ou não.
    public bool ehMaior()
    {
        bool ehMaior = false;

        if(idade >= 18) ehMaior = true;

        return ehMaior;
    }

    // Para a classe da questão anterior, implemente o método maisVelho(Pessoa):Pessoa. Ele deve
    // calcular e retornar a instância (objeto) de Pessoa relativa à pessoa mais velha, a corrente ou aquela
    // recebida por parâmetro.

    public Pessoa maisVelho(Pessoa p2)
    {
        Pessoa maisVelho = this;

        if(p2.getIdade() > this.idade)
        {
            maisVelho = p2;
        }

        return maisVelho;
    }
}

// Construa a classe Aluno como uma especialização da classe Pessoa. Ela deverá acrescentar o atributo
// relativo ao número de matrícula do aluno. Deverá também prover um construtor com três argumentos:
// o número de matrícula do aluno, seu nome e sua idade.
class Aluno : Pessoa
{
    private long numeroMatricula;

    public Aluno(long numeroMatricula, string nome, int idade) : base(nome, idade){
        this.numeroMatricula = numeroMatricula;
    }
}