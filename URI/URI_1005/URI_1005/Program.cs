using System;
using System.Globalization;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, mediaA, mediaB, Media;
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaA = A * 3.5;
            mediaB = B * 7.5;


            Media = (mediaA + mediaB) / 11;


            Console.WriteLine("MEDIA = " + Media.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
