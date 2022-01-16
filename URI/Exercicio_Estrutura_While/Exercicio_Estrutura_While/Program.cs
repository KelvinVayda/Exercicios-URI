using System;
using System.Globalization;
namespace Exercicio_Estrutura_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, soma, media;
            int cont = 0;
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            while (x >= 0)
            {
                soma = soma + x;
                cont++;
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            if (cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

        }

    }
}
