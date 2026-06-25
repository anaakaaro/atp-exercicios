// Construa uma função que verifique quantos elementos na matriz são iguais ao maior valor nela presente.
// Argumentos da função: uma matriz de reais em que não há garantia de valores distintos, ao contrário, um
// mesmo valor pode ocorrer diversas vezes na matriz.

class Program
{
    static int IguaisAoMaior(double[,] m)
    {
        int iguais = 0;
        int maior = m[0,0];

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] > maior)
                {
                    maior = m[i,j];
                }
            }
        }

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(m[i,j] == maior)
                {
                    iguais++;
                }
            }
        }

        return iguais;
    }
}
