// Construa uma função que receba dois parâmetros: um vetor de referências para quadrados e um valor
// inteiro relativo à posição k do vetor que deverá ser removida. A função deverá remover o quadrado da
// posição k parametrizada e deslocar em uma posição os demais objetos posicionados à frente do
// quadrado removido (shift -1), garantindo assim que todos os elementos permaneçam contíguos. Em
// seguida, deverá ser atualizado o tamanho lógico do vetor: um atributo estático da classe Quadrado
// denominado quantidade. Garanta o sucesso da exclusão certificando ser k um valor válido, isto é, dentro
// do limite do tamanho lógico do arranjo.

class Program
{
    static void Main()
    {
        Quadrado[] quadrados = new Quadrado[10];

        // para cada instância, guardar o valor do lado fornecido pelo usuário;
        for(int i = 0; i < 5; i++)
        {
            quadrados[i] = new Quadrado();
            quadrados[i].lerLado();
            Quadrado.aumentarQuantidade();
        }

        Console.WriteLine($"Quantidade de quadrados: {Quadrado.getQuantidade()}");

        removeQuadrado(quadrados, 3);

        Console.Write($"Quantidade de quadrados: {Quadrado.getQuantidade()}");
    }
    static void removeQuadrado(Quadrado[] v, int k)
    {
        if(k < 0 || k >= Quadrado.getQuantidade()) return;

        for(int i = k; i < Quadrado.getQuantidade()-1; i++)
        {
            v[i] = v[i+1];
        }

        Quadrado.diminuirQuantidade();
    }
}


class Quadrado
{
    private int lado;
    private static int quantidade = 0;

    public static int getQuantidade()
    {
        return quantidade;
    }

    public static void diminuirQuantidade()
    {
        if(quantidade > 0) quantidade--;
    }

    public static void aumentarQuantidade()
    {
        quantidade++;
    }

    public void setLado(int lado)
    {
        if(lado > 0)
        {
            this.lado = lado;
        }
    }

    public int getLado()
    {
        return lado;
    }

    public void lerLado()
    {
        Console.Write("Digite o valor do lado: ");
        int lado = int.Parse(Console.ReadLine());
        setLado(lado);
    }

}
