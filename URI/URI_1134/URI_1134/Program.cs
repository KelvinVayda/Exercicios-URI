using System;

namespace URI_1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int Al = 0;
            int Gas = 0;
            int Dis = 0;
            int comb = int.Parse(Console.ReadLine());

            while (comb != 4)
            {
                if (comb == 1)
                {
                    Al++;
                }
                else if (comb == 2)
                {
                    Gas++;
                }
                else if (comb == 3)
                {
                    Dis++;
                }
                comb = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Al);
            Console.WriteLine("Gasolina: " + Gas);
            Console.WriteLine("Diesel: " + Dis);
        }
    }
}

