using System;
using System.Globalization;
namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {

            int func, h;
            double hx, salary;
            func = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            hx = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salary = h * hx;

            Console.WriteLine("NUMBER = " + func);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
