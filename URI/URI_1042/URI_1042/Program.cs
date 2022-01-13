using System;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] val = Console.ReadLine().Split(' ');
            int x = int.Parse(val[0]);
            int y = int.Parse(val[1]);
            int z = int.Parse(val[2]);
            int maior, meio, menor;

            if (x < y && x < z)
            {
                menor = x;
                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < z)
            {
                menor = y;
                if (x < z)
                {
                    meio = x;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = x;
                }
            }
            else
            {
                menor = z;
                if (x < y)
                {
                    meio = x;
                    maior = y;
                }
                else
                {
                    meio = y;
                    maior = x;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}