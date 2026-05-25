//Construa uma função que receba um valor inteiro relativo a um mês do ano [1..12]. A função deverá
//retornar o número de dias que o mês possui.
using System;

class Program
{
    static void Main()
    {
        Console.Write(DiasNoMes(7));
    }

    static int DiasNoMes(int mes)
    {
        int dias = 0;

        switch (mes)
        {
            case 1:
            dias = 31;
            break;

            case 2:
            dias = 28;
            break;

            case 3:
            dias = 31;
            break;

            case 4:
            dias = 30;
            break;

            case 5:
            dias = 31;
            break;

            case 6:
            dias = 30;
            break;

            case 7:
            dias = 31;
            break;

            case 8:
            dias = 31;
            break;

            case 9:
            dias = 30;
            break;

            case 10:
            dias = 31;
            break;

            case 11:
            dias = 30;
            break;

            case 12:
            dias = 31;
            break;
        }

        return dias;
    }
}
