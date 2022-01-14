using System;
using System.Globalization;

namespace URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, perimetro, area;

            string[] ent = Console.ReadLine().Split(' ');
            A = double.Parse(ent[0], CultureInfo.InvariantCulture);
            B = double.Parse(ent[1], CultureInfo.InvariantCulture);
            C = double.Parse(ent[2], CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B )
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else 
            {
                area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
