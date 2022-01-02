using System;
using System.Globalization;
namespace URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (n1 < 0.0 || n1 > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (n1 <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (n1 <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (n1 <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
