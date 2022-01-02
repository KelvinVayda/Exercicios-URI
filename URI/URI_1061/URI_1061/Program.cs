using System;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int W1, X1, Y1, Z1, W2, X2, Y2, Z2, w, x, y, z, inicio, fim, duracao, resto;

            string[] valores = Console.ReadLine().Split(' ');
            W1 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X1 = int.Parse(valores[0]);
            Y1 = int.Parse(valores[2]);
            Z1 = int.Parse(valores[4]);

            valores = Console.ReadLine().Split(' ');
            W2 = int.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            X2 = int.Parse(valores[0]);
            Y2 = int.Parse(valores[2]);
            Z2 = int.Parse(valores[4]);

            inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
            fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

            duracao = fim - inicio;


            w = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            x = resto / (60 * 60);
            resto = resto % (60 * 60);
            y = resto / 60;
            z = resto % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");
        }
    }
}
