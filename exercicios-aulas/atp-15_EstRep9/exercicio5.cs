//Leia vários números até ser digitado o valor 0 e informe:
//quantos são pares
//quantos são ímpares
using System;

class Program
{
    static void Main()
    {
        int numero;
        int numerosPares = 0;
        int numerosImpares = 0;

        do
        {
            Console.Write("Digite um número [0 p/ sair]: ");
            numero = int.Parse(Console.ReadLine());
            if(numero !=0){
                if(numero % 2 == 0){numerosPares ++;}
                else{numerosImpares++;}
            }

        } while (numero != 0);

        Console.WriteLine($"Total de números pares: {numerosPares}");
        Console.WriteLine($"Total de números impares: {numerosImpares}");
        
        
    }
}