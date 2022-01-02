using System;
using System.Globalization;
namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int item = int.Parse(entrada[0]);
            int qtd = int.Parse(entrada[1]);

            double total = 0;
            switch (item)
            {
                case 1:
                    total = qtd * 4.0;
                    break;
                case 2:
                    total = qtd * 4.5;
                    break;
                case 3:
                    total = qtd * 5.0;
                    break;
                case 4:
                    total = qtd * 2.0;
                    break;
                case 5:
                    total = qtd * 1.50;
                    break;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

