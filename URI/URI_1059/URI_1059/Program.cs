using System;

namespace URI_1059
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;

            while (n <= 100 )
            {
                if (n % 2 == 0)
                {                    
                    Console.WriteLine(n);
                    n = n + 2 ;
                }
            }
        }
    }
}
