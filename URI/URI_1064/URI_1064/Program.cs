using System;
using System.Globalization;

namespace URI_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, soma;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            int cont = 0;

            if (n1 > 0.0)
            {
                cont = cont + 1;
                soma = soma + n1;
            }
            if (n2 > 0.0)
            {
                cont = cont + 1;
                soma = soma + n2;
            }
            if (n3 > 0.0)
            {
                cont = cont + 1;
                soma = soma + n3;
            }
            if (n4 > 0.0)
            {
                cont = cont + 1;
                soma = soma + n4;
            }
            if (n5 > 0.0)
            {
                cont = cont + 1;
                soma = soma + n5;
            }
            if (n6 > 0)
            {
                cont = cont + 1;
                soma = soma + n6;
            }
            Console.WriteLine(cont + " valores positivos");
            double media = soma / cont ;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

       
    

