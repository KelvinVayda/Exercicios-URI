using System;

namespace URI_1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] n = Console.ReadLine().Split(' ');
            A = int.Parse(n[0]);
            B = int.Parse(n[1]);
            C = int.Parse(n[2]);
            D = int.Parse(n[3]);


            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
