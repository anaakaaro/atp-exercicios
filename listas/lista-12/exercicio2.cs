// Considere uma matriz quadrada de reais de dimensão MAX x MAX. Implemente uma função inteira
// que receba tal matriz e retorne em qual posição da matriz quadrada está o maior valor, sendo: 0, caso o
// maior valor esteja na diagonal principal; +1, caso o maior valor esteja acima da diagonal principal; -1,
// caso esteja abaixo dela. Fique à vontade para distribuir a tarefa a mais que uma função, caso julgue
// necessário.

using System.Runtime.Serialization;

class Program
{
    static int PosicaoMaiorValor(double[,] m)
    {
        int posicao = -2;
        int linhas = m.GetLength(0);
        int colunas = m.GetLength(1);
        double maiorDiagonal = maiorValorDiagonalPrincipal(m);
        double maiorAcima = maiorAcimaDiagonalPrincipal(m);
        double maiorAbaixo = maiorAbaixoDiagonalPrincipal(m);

        if(linhas == colunas)
        {
            if(maiorDiagonal >= maiorAcima && maiorDiagonal >= maiorAbaixo)
            {
                posicao = 0;
            } else if(maiorAcima >= maiorDiagonal && maiorAcima >= maiorAbaixo)
            {
                posicao = 1;
            } else {
                posicao = -1;
            }
        }

        return posicao;
        
    }

    static double maiorAbaixoDiagonalPrincipal(double[,] m)
    {
        double maiorValor = m[1,0];

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(i > j)
                {
                    if(m[i,j] > maiorValor)
                    {
                        maiorValor = m[i,j];
                    }
                }
            }
        }

        return maiorValor;
    }

    static double maiorAcimaDiagonalPrincipal(double[,] m)
    {
        double maiorValor = m[0,1];

        for(int i = 0; i < m.GetLength(0); i++)
        {
            for(int j = 0; j < m.GetLength(1); j++)
            {
                if(j > i)
                {
                    if(m[i,j] > maiorValor)
                    {
                        maiorValor = m[i,j];
                    }
                }
            }
        }

        return maiorValor;
    }

    static double maiorValorDiagonalPrincipal(double[,] m)
    {
        double maiorValor = m[0,0];

        for(int i = 1; i < m.GetLength(0); i++)
        {
            if(m[i,i]> maiorValor)
            {
                maiorValor = m[i,i];
            }
        }

        return maiorValor;
    }
}