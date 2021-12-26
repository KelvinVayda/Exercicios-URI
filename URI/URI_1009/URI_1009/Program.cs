using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME;
            double perc;
            double sal, vendas, TOTAL;
            NOME = (Console.ReadLine());
            sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            perc = 15.0 / 100.0;
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TOTAL = sal + (vendas * perc);

            Console.WriteLine("TOTAL = R$ " + TOTAL.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
