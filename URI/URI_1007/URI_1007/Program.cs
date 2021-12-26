using System;

namespace URI_1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, Dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            Dif = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + Dif);


        }
    }
}
