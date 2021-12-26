using System;
using System.Globalization;

namespace URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, r, n = 3.14159;
            r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = n * r * r;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));



        }
    }
}
