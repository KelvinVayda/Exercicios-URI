using System;
using System.Globalization;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {

            int x;
            double y, Total;
            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Total = x / y;

            Console.WriteLine(Total.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
