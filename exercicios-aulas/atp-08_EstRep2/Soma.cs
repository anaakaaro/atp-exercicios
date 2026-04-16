//Calcular a soma de dez números lidos. Em seguida, escrever o resultado.

using System;
class Program{
    static void Main(){
        double numero, soma = 0;

        for(int i = 0; i <10; i++)
        {
            Console.WriteLine("Digite um valor:");
            numero = double.Parse(Console.ReadLine());
            soma += numero;
        }
        Console.WriteLine($"Resultado da soma: {soma}");
    }
}
