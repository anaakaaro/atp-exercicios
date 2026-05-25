//Construa uma função que receba um valor inteiro relativo a um mês do ano [1..12]. A função deverá
//retornar o nome do mês por extenso.

using System;

class Program
{
    static void Main()
    {
        Console.Write(NomeDoMes(6));
    }

    static string NomeDoMes(int mes)
    {
        string nomeMes = "";

        switch (mes)
        {
            case 1:
            nomeMes = "Janeiro";
            break;

            case 2:
            nomeMes = "Fevereiro";
            break;

            case 3:
            nomeMes = "Março";
            break;

            case 4:
            nomeMes = "Abril";
            break;

            case 5:
            nomeMes = "Maio";
            break;

            case 6:
            nomeMes = "Junho";
            break;

            case 7:
            nomeMes = "Julho";
            break;

            case 8:
            nomeMes = "Agosto";
            break;

            case 9:
            nomeMes = "Setembro";
            break;

            case 10:
            nomeMes = "Outubro";
            break;

            case 11:
            nomeMes = "Novembro";
            break;

            case 12:
            nomeMes = "Dezembro";
            break;
        }

        return nomeMes;
    }
}