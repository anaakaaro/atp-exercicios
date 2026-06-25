//Receber um vetor de salários e conceder aumento de 5%

class Program
{
    static void Main()
    {
        double[] salarios = {1596, 2000, 4563};
        AumentaSalario(salarios);

        foreach(double salario in salarios)
        {
            Console.WriteLine(salario);
        }
    }
    static void AumentaSalario(double[] v)
    {
        for(int i = 0; i < v.Length; i++)
        {
            v[i] += v[i] * 0.05;
        }
    }
}