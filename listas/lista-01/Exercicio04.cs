// 4. Uma família desejar planejar sua viagem. A partir da distância a ser percorrida (em Km) e da velocidade
// média que tipicamente praticam em suas viagens (Km/h), calcule e escreva o tempo que gastarão na
// viagem. Lembre-se que:
// Distância = Tempo x Velocidade

using System;
class Exercicio04 {
    static void Main()
    {
        Console.WriteLine("Digite a distância a ser percorrida:");
        double distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade média:");
        double velocidade = double.Parse(Console.ReadLine());

        double tempo = distancia / velocidade;
        Console.WriteLine($"Vocês gastarão {tempo} horas na viagem");
    }
}