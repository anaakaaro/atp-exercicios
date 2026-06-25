
class Program
{
    static void Main()
    {
        Console.Write("Digite a quantidade de cidades: ");
        int TAM = int.Parse(Console.ReadLine());

        Cidade[] cidades = new Cidade[TAM];

        int opcao;
        int i = 0;

        do
        {
            opcao = Menu();

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Obrigado!");
                    break;
                
                case 1:
                    if(i < TAM){
                        cidades[i] = new Cidade();
                        cidades[i].CadastrarCidade();
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Vetor cheio");
                    }
                    break;

                case 2:
                    ListaBateVolta(cidades);
                    break;

                case 3:
                    Console.Write("Digite a distância: ");
                    int distancia = int.Parse(Console.ReadLine());
                    Console.Write(DistanciaMaiorQueChave(cidades, distancia));
                    break;
                
            }
        } while(opcao != 0);
        
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
        opcao = int.Parse(Console.ReadLine());

        return opcao;
    }

    static void ListaBateVolta(Cidade[] c)
    {
        for(int i = 0; i < Cidade.getQuantidade(); i++)
        {
            if(c[i].getDistanciaBH() <= 60)
            {
                Console.Write($"{c[i].getNomeCidade()} | Distância: {c[i].getDistanciaBH()}");
            }
        }
    }

    static int DistanciaMaiorQueChave(Cidade[] c, int distancia)
    {
        int cidades = 0;

        for(int i = 0; i < Cidade.getQuantidade(); i++)
        {
            if(c[i].getDistanciaBH() > distancia)
            {
                cidades++;
            }
        }

        return cidades;
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

    public bool DistanciaEhMenor(int distancia)
    {
        bool ehMenor = false;

        if(this.distanciaBH <= distancia)
        {
            ehMenor = true;
        }

        return ehMenor;
    }
    
}