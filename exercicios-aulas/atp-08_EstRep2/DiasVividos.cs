//Calcular o número de dias vividos até o último aniversário. Ignorar anos
//bissextos. Rejeitar idade inválida, sabendo que: idade 0..150
using System;
class Program{
    static void Main(){
        int idade, dias_vividos;

        do{
            Console.WriteLine("Digite a sua idade [0...150]:");
            idade = int.Parse(Console.ReadLine());
            if(idade <0 || idade > 150){
                Console.WriteLine("Digite uma idade válida.");
            }
        } while (idade < 0 || idade >150);

        dias_vividos = idade * 365;
        Console.WriteLine($"Você viveu {dias_vividos} dias.");
    }
}