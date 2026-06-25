// Construa uma função que receba um arranjo de números reais e verifique se ele é monotonicamente
// crescente (cada elemento é maior ou igual ao anterior).
// Exemplo: caso seja o vetor abaixo aquele recebido pela função:

class Program()
{
    static bool EhCrescente(int[] v)
    {
        bool ehCrescente = true;
        int i = 0;

        while(i < v.Length-1 && ehCrescente){
                if(v[i] > v[i + 1])
                {
                    ehCrescente = false;
                }
                i++;
            }

        return ehCrescente;
    }
}