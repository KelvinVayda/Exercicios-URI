using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, pi, resultado;
            R = double.Parse(Console.ReadLine());
            pi = 3.14159;
            resultado = (4 / 3.0) * pi * (R * R * R);

            Console.WriteLine("VOLUME = " + resultado.ToString("F3", CultureInfo.InvariantCulture));

        
        }

    }
}
