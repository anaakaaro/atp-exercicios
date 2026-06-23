namespace TrabalhoPratico
{
    class Data
    {
        private int dia;
        private int mes;
        private int ano;

        public bool setDia(int dia)
        {
            bool sucesso = false;

            if(dia >= 0 && dia <= 31)
            {
                this.dia = dia;
                sucesso = true;
            }

            return sucesso;
        }

        public bool setMes(int mes)
        {
            bool sucesso = false;
            
            if(mes >= 0 && mes <= 12)
            {
                this.mes = mes;
                sucesso = true;
            }

            return sucesso;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public bool setData(int dia, int mes, int ano)
        {
            bool sucesso = false;

            if(dia >= 0 && dia <= 31 && mes >= 0 && mes <= 12)
            {
                setDia(dia);
                setMes(mes);
                setAno(ano);

                sucesso = true;
            }

            return sucesso;
        }

        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }

        public int getAno()
        {
            return ano;
        }

        public bool dataValida()
        {
            bool dataValida = false;

            if(dia >= 1 && dia <= 31 && mes >= 1 && mes <= 12)
            {
                dataValida = true;
            }

            return dataValida;
        }

        public string mesExtenso(int mes)
        {
            String[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
            string mesExtenso = "";

            switch (mes)
            {
                case 1:
                    mesExtenso = meses[0];
                    break;

                case 2:
                    mesExtenso = meses[1];
                    break;

                case 3:
                    mesExtenso = meses[2];
                    break;

                case 4:
                    mesExtenso = meses[3];
                    break;

                case 5:
                    mesExtenso = meses[4];
                    break;

                case 6:
                    mesExtenso = meses[5];
                    break;

                case 7:
                    mesExtenso = meses[6];
                    break;

                case 8:
                    mesExtenso = meses[7];
                    break;

                case 9:
                    mesExtenso = meses[8];
                    break;

                case 10:
                    mesExtenso = meses[9];
                    break;

                case 11:
                    mesExtenso = meses[10];
                    break;

                case 12:
                    mesExtenso = meses[11];
                    break;
            }

            return mesExtenso;
        }

        public int diasMes(int mes)
        {
            int[] dias = {31,28,31,30,31,30,31,31,30,31,30,31};
            int diasMes = 0;

            switch (mes)
            {
                case 1:
                    diasMes = dias[0];
                    break;

                case 2:
                    diasMes = dias[1];
                    break;

                case 3:
                    diasMes = dias[2];
                    break;

                case 4:
                    diasMes = dias[3];
                    break;

                case 5:
                    diasMes = dias[4];
                    break;

                case 6:
                    diasMes = dias[5];
                    break;

                case 7:
                    diasMes = dias[6];
                    break;

                case 8:
                    diasMes = dias[7];
                    break;

                case 9:
                    diasMes = dias[8];
                    break;

                case 10:
                    diasMes = dias[9];
                    break;

                case 11:
                    diasMes = dias[10];
                    break;

                case 12:
                    diasMes = dias[11];
                    break;
            }

            return diasMes;
        }

        public void escreveData()
        {
            Console.WriteLine($"{dia}/{mes}/{ano}");
        }

        public void leiaData()
        {
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            setData(dia, mes, ano);
        }
    }
}