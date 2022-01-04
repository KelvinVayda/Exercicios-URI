using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {

            int horasInicio, minutosInicio, horasFim, minutosFim, h, m, inicio, fim, duracao;

            String[] valores = Console.ReadLine().Split(' ');
            horasInicio = int.Parse(valores[0]);
            minutosInicio = int.Parse(valores[1]);
            horasFim = int.Parse(valores[2]);
            minutosFim = int.Parse(valores[3]);

            inicio = horasInicio * 60 + minutosInicio;
            fim = horasFim * 60 + minutosFim;

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = (24 * 60 - inicio) + fim;
            }

            h = duracao / 60;
            m = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + h + " HORA(S) E " + m + " MINUTO(S)");



        }
    }
}
