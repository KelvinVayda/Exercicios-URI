using System;

namespace URI_1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            while (x != 0)
            {   // Se for impar, some mais 1
                if (x % 2 != 0)
                {
                    x++;
                }
                // expressao simplificada: 5 * x + 20
                int soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);

                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
