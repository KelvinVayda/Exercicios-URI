using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            string[] n = Console.ReadLine().Split(' ');
            A = int.Parse(n[0]);
            B = int.Parse(n[1]);

            if (B % A == 0 || A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");

            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");

            }
        }
    }
}