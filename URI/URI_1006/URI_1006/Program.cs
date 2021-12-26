using System;
using System.Globalization;

namespace URI_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, mediaA, mediaB, mediaC, Media;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaA = A * 2.0;
            mediaB = B * 3.0;
            mediaC = C * 5.0;

            Media = (mediaA + mediaB + mediaC) / 10;


            Console.WriteLine("MEDIA = " + Media.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
