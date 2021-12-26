using System;
using System.Globalization;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int hr, km;
            double Resultado;
            hr = int.Parse(Console.ReadLine());
            km = int.Parse(Console.ReadLine());
            Resultado = (km * hr) / 12.0;


            Console.WriteLine(Resultado.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
