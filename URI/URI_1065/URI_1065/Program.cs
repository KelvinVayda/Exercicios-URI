using System;

namespace URI_1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, par;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());
            par = 0;

            if (n1 % 2 == 0)
            {
                par = par + 1;
            }
            if (n2 % 2 == 0)
            {
                par = par + 1;
            }
            if (n3 % 2 == 0)
            {
                par = par + 1;
            }
            if (n4 % 2 == 0)
            {
                par = par + 1;
            }
            if (n5 % 2 == 0)
            {
                par = par + 1;
            }
            Console.WriteLine(par + " valores pares");
        }
    }
}
