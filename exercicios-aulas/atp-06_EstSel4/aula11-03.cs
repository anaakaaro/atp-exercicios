//Aula 11/03/2026
using System;

class Program {
    static void Main(){
        Console.WriteLine("Digite o estado civil: (s/c/d/v)");
        char estadoCivil = char.Parse(Console.ReadLine());

        switch (estadoCivil) {
            case 's':
                Console.WriteLine("Solteiro");
                break;
                
            case 'c':
                Console.WriteLine("Casado");
                break;

            case 'd':
                Console.WriteLine("Divorciado");
                break;

            case 'v':
                Console.WriteLine("Viúvo");
                break;

            default: Console.WriteLine("Inválido");
            break;
        }
    }
}