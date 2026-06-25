using System;

class Program
{
    static void Main()
    {
        // Criar uma coleção de instâncias de quadrado (de tamanho MAX) e
        int max = 5;
        Quadrado[] quadrados = new Quadrado[max];

        // para cada instância, guardar o valor do lado fornecido pelo usuário;
        for(int i = 0; i < max; i++)
        {
            quadrados[i] = new Quadrado();
            quadrados[i].lerLado();
        }

        // para cada instância, escrever na tela:
        for(int i = 0; i < max; i++)
        {
            // a sequência do quadrado (1, 2, 3 etc.)
            Console.WriteLine($"Quadrado {i+1}:");
            //o valor do lado daquele quadrado
            quadrados[i].escreverLado();
            // o perímetro daquele quadrado
            Console.WriteLine($"Perímetro: {quadrados[i].calcularPerimetro()}");
            // a área daquele quadrado
            Console.WriteLine($"Área: {quadrados[i].calcularArea()}");
        }
    }
}

// Considere o tipo Quadrado descrito pelo seguinte atributo (dado-membro):
// Lado, um atributo do tipo real
class Quadrado
{
    int lado;

    // Atribuir um valor parametrizado ao atributo Lado - rejeitar valor negativo;
    public void setLado(int lado)
    {
        if(lado > 0)
        {
            this.lado = lado;
        }
    }

    // Recuperar o valor do atributo Lado;
    public int getLado()
    {
        return lado;
    }

    // Gerar o perímetro do quadrado;
    public int calcularPerimetro()
    {
        return 4 * lado;
    }

    // Gerar a área do quadrado;
    public int calcularArea()
    {
        return lado * lado;
    }

    // Ler um valor do teclado e guardá-lo no atributo Lado;
    public void lerLado()
    {
        Console.Write("Digite o valor do lado: ");
        int lado = int.Parse(Console.ReadLine());
        setLado(lado);
    }

    // Escreva na tela do monitor de vídeo o valor atribuído ao atributo Lado.
    public void escreverLado()
    {
        Console.WriteLine($"Lado: {lado}");
    }

}
