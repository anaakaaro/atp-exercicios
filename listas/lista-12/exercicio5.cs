
class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de cidades: ");
        int TAM = int.Parse(Console.ReadLine());

        Cidade[] cidades = new Cidade[TAM];
    }

    static int Menu()
    {
        int opcao = -1;

        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("0 - Sair do Programa");
        Console.WriteLine("1 - Cadastrar uma cidade ");
        Console.WriteLine("2 - Listar bate-e-volta");
        Console.WriteLine("3 - Listar cidades acima de x quilômetros");
        Console.Write("Informe sua opção: ");
        opcao = int.Parse(COnsole.ReadLine());

        return opcao;
    }

    


}
class Cidade
{
    private string nomeCidade;
    private int distanciaBH;

    private static int quantidade = 0;

    public static int getQuantidade()
    {
        return quantidade;
    }

    public static void aumentarQuantidade()
    {
        quantidade++;
    }

    public static void diminuitQuantidade()
    {
        if(quantidade > 0) quantidade--;
    }

    public void setNomeCidade(string nomeCidade)
    {
        this.nomeCidade = nomeCidade;
    }

    public string getNomeCidade()
    {
        return nomeCidade;
    }

    public void setDistanciaBH(int distanciaBH)
    {
        this.distanciaBH = distanciaBH;
    }

    public int getDistanciaBH()
    {
        return distanciaBH;
    }

    public void CadastrarCidade()
    {
        Console.Write("Digite o nome da cidade: ");
        string nome = Console.ReadLine();
        setNomeCidade(nome);

        Console.Write("Digite a distância de BH: ");
        int distanciaBH = int.Parse(Console.ReadLine());
        setDistanciaBH(distanciaBH);

        Cidade.aumentarQuantidade();
    }
    
}