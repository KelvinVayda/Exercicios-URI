using System;
using System.Globalization;
namespace URI_1060
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

            if (n1 > 0)
            {
                soma = soma + 1;
            }
            if (n2 > 0)
            { 
                soma = soma + 1;
            }
            if (n3 > 0)
            {
                soma = soma + 1;
            }
            if (n4 > 0)
            {
                soma = soma + 1;
            }
            if (n5 > 0)
            {
                soma = soma + 1;
            }
            if (n6 > 0)
            {
                soma = soma + 1;
            }
            Console.WriteLine(soma + " valores positivos");
        }
    }
}

